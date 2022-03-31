using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MinecraftMappings.Internal.Models.Block
{
    public interface IBlockModel
    {
        string Name {get;}
        BlockModelVersion GetLatestVersion();
        //ModelVersion GetVersion(Version version);
    }

    public abstract class BlockModel : IBlockModel
    {
        protected static readonly RectangleF UVFull = new(0f, 0f, 16f, 16f);

        public string Name {get; set;}
        public List<BlockModelVersion> Versions {get; set;}


        protected BlockModel(string name)
        {
            Name = name;
            Versions = new List<BlockModelVersion>();
        }

        protected BlockModelVersionBuilder AddVersion(string id, string minVersion, string maxVersion = null)
        {
            var modelVersion = new BlockModelVersion {
                Id = id,
                MinVersion = minVersion,
                MaxVersion = maxVersion,
            };

            Versions.Add(modelVersion);
            return new BlockModelVersionBuilder(modelVersion);
        }

        public BlockModelVersion GetLatestVersion()
        {
            return Versions.OrderByDescending(v => v.ParsedMinVersion)
                .FirstOrDefault();
        }

        protected static RectangleF UVMap(in float left, in float top, in float right, in float bottom) =>
            UVHelper.UVMap(in left, in top, in right, in bottom);

        public static IEnumerable<T> FromAssembly<T>()
            where T : IBlockModel
        {
            return Assembly.GetExecutingAssembly()
                .ExportedTypes.Where(t => !t.IsAbstract)
                .Where(t => typeof(T).IsAssignableFrom(t))
                .Select(t => (T) Activator.CreateInstance(t));
        }
    }
}
