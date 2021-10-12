using System;

namespace MinecraftMappings.Internal.Blocks
{
    public abstract class BedrockBlockData : BlockData<BedrockBlockDataVersion>
    {
        protected BedrockBlockData(string name) : base(name) {}

        protected BedrockBlockVersionBuilder<BedrockBlockDataVersion> AddVersion(string id)
        {
            var version = new BedrockBlockDataVersion {
                Id = id,
            };

            Versions.Add(version);
            return new BedrockBlockVersionBuilder<BedrockBlockDataVersion>(version);
        }
    }

    public class BedrockBlockDataVersion : BlockDataVersion
    {
        public string MapsToJavaId {get; set;}
        public Type MapsToJavaBlock {get; set;}
    }
}
