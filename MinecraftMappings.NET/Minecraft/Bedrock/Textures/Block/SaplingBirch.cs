using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class SaplingBirch : BedrockBlockTexture
    {
        public SaplingBirch() : base("Sapling Birch")
        {
            AddVersion("sapling_birch")
                .MapsToJavaBlock<Java.Textures.Block.BirchSapling>();
        }
    }
}
