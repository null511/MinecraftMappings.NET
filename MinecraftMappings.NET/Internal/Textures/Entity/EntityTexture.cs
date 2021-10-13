using MinecraftMappings.Internal.Textures.Block;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MinecraftMappings.Internal.Textures.Entity
{
    public interface IEntityTexture
    {
        string Name {get;}
    }

    public interface IEntityTexture<out TEntityVersion> : IEntityTexture
        where TEntityVersion : EntityTextureVersion
    {
        TEntityVersion GetLatestVersion();
    }

    public abstract class EntityTexture : IEntityTexture
    {
        public string Name {get;}


        protected EntityTexture(string name)
        {
            Name = name;
        }

        public static IEnumerable<T> FromAssembly<T>()
            where T : IBlockTexture
        {
            return Assembly.GetExecutingAssembly()
                .ExportedTypes.Where(t => t.IsClass && !t.IsAbstract)
                .Where(t => typeof(T).IsAssignableFrom(t))
                .Select(t => (T) Activator.CreateInstance(t));
        }
    }

    public abstract class EntityTexture<TVersion> : EntityTexture, IEntityTexture<TVersion>
        where TVersion : EntityTextureVersion, new()
    {
        public List<TVersion> Versions {get;}


        protected EntityTexture(string name) : base(name)
        {
            Versions = new List<TVersion>();
        }

        public TVersion GetLatestVersion()
        {
            // WARN: temp hack - not actually using version!
            return Versions.FirstOrDefault();
        }

        protected void AddVersion(string id, Action<TVersion> versionAction)
        {
            var version = new TVersion {
                Id = id,
            };

            versionAction(version);
            Versions.Add(version);
        }

        //protected abstract BlockVersionBuilder<TVersion> AddVersion(string id);
        //{
        //    var version = new TVersion {
        //        Id = id,
        //    };

        //    Versions.Add(version);
        //    return new BlockVersionBuilder<TVersion>(version);
        //}
    }
}
