using MinecraftMappings.Internal.Extensions;
using SharpDX;
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
        TEntityVersion? GetLatestVersion();
        TEntityVersion? GetVersion(Version version);
    }

    public abstract class EntityModel : IEntityModel
    {
        public string Name {get;}


        protected EntityModel(string name)
        {
            Name = name;
        }

        protected static RectangleF UVMap(in float left, in float top, in float right, in float bottom) =>
            UVHelper.UVMap(in left, in top, in right, in bottom);

        public static IEnumerable<T> FromAssembly<T>()
            where T : IEntityModel
        {
            return Assembly.GetExecutingAssembly()
                .ExportedTypes.Where(t => !t.IsAbstract)
                .Where(t => typeof(T).IsAssignableFrom(t))
                .Select(t => (T?) Activator.CreateInstance(t))
                .WhereNotNull();
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
                MinVersion = version,
            };

            Versions.Add(entityVersion);
            return new EntityVersionBuilder<TVersion>(entityVersion);
        }

        public TVersion? GetLatestVersion()
        {
            return Versions.OrderByDescending(v => v.ParsedMinVersion)
                .FirstOrDefault();
        }

        public TVersion? GetVersion(Version version)
        {
            return Versions.OrderByDescending(e => e.ParsedMinVersion)
                .FirstOrDefault(e => e.ParsedMinVersion <= version);
        }
    }
}
