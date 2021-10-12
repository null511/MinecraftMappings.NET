using System;

namespace MinecraftMappings.Internal.Blocks
{
    public abstract class JavaBlockData : BlockData<JavaBlockDataVersion>
    {
        protected JavaBlockData(string name) : base(name) {}

        protected JavaBlockVersionBuilder<JavaBlockDataVersion> AddVersion(string id)
        {
            var version = new JavaBlockDataVersion {
                Id = id,
            };

            Versions.Add(version);
            return new JavaBlockVersionBuilder<JavaBlockDataVersion>(version);
        }
    }

    public class JavaBlockDataVersion : BlockDataVersion
    {
        public string MapsToBedrockId {get; set;}
        public Type MapsToBedrockBlock {get; set;}
    }
}
