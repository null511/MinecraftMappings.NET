using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class SaplingBirch : BedrockBlockData
    {
        public SaplingBirch() : base("Sapling Birch")
        {
            AddVersion("sapling_birch", version => {
                version.MapsToJavaBlock = typeof(BirchSapling);
            });
        }
    }
}
