using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MinecraftMappings.Internal.Models.Entity
{
    public interface IEntityModel
    {
        string Name {get;}
    }

    public interface IEntityModel<out TEntityVersion> : IEntityModel
        where TEntityVersion : EntityModelVersion, new()
    {
        TEntityVersion GetLatestVersion();
        TEntityVersion GetVersion(Version version);
    }

    public abstract class EntityModel : IEntityModel
    {
        public string Name {get;}


        protected EntityModel(string name)
        {
            Name = name;
        }

        public static IEnumerable<T> FromAssembly<T>()
            where T : IEntityModel
        {
            return Assembly.GetExecutingAssembly()
                .ExportedTypes.Where(t => !t.IsAbstract)
                .Where(t => typeof(T).IsAssignableFrom(t))
                .Select(t => (T) Activator.CreateInstance(t));
        }
    }

    public abstract class EntityModel<TVersion> : EntityModel, IEntityModel<TVersion>
        where TVersion : EntityModelVersion, new()
    {
        public List<TVersion> Versions {get;}


        protected EntityModel(string name) : base(name)
        {
            Versions = new List<TVersion>();
        }

        public EntityVersionBuilder<TVersion> AddVersion(string id, string version)
        {
            var entityVersion = new TVersion {
                Id = id,
                TextVersion = version,
            };

            Versions.Add(entityVersion);
            return new EntityVersionBuilder<TVersion>(entityVersion);
        }

        public TVersion GetLatestVersion()
        {
            return Versions.OrderByDescending(v => v.ParsedVersion)
                .FirstOrDefault();
        }

        public TVersion GetVersion(Version version)
        {
            return Versions.OrderByDescending(e => e.ParsedVersion)
                .FirstOrDefault(e => e.ParsedVersion <= version);
        }
    }
}
