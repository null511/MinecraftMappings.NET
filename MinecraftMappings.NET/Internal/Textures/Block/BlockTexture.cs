﻿using MinecraftMappings.Internal.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MinecraftMappings.Internal.Textures.Block
{
    public interface IBlockTexture
    {
        string Name {get;}
    }

    public interface IBlockTexture<out TBlockVersion> : IBlockTexture
        where TBlockVersion : BlockTextureVersion
    {
        int BlendMode {get; set;}
        IEnumerable<TBlockVersion> Versions {get;}

        TBlockVersion? GetLatestVersion();
    }

    public abstract class BlockTexture : IBlockTexture
    {
        public string Name {get;}


        protected BlockTexture(string name)
        {
            Name = name;
        }

        public static IEnumerable<T> FromAssembly<T>()
            where T : IBlockTexture
        {
            return Assembly.GetExecutingAssembly()
                .ExportedTypes.Where(t => t.IsClass && !t.IsAbstract)
                .Where(t => typeof(T).IsAssignableFrom(t))
                .Select(t => (T?) Activator.CreateInstance(t))
                .WhereNotNull();
        }
    }

    public abstract class BlockTexture<TVersion> : BlockTexture, IBlockTexture<TVersion>
        where TVersion : BlockTextureVersion, new()
    {
        public int BlendMode {get; set;}
        public List<TVersion> Versions {get;}

        IEnumerable<TVersion> IBlockTexture<TVersion>.Versions => Versions;


        protected BlockTexture(string name) : base(name)
        {
            BlendMode = BlendModes.Opaque;
            Versions = new List<TVersion>();
        }

        //public TVersion FindVersionById()
        //{
        //    // WARN: temp hack - not actually using version!
        //    return Versions.FirstOrDefault();
        //}

        public TVersion? GetLatestVersion()
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
