using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class CoarseDirt : BedrockBlockTexture
    {
        public CoarseDirt() : base("Coarse Dirt")
        {
            AddVersion("coarse_dirt")
                .MapsToJavaBlock<Java.Textures.Block.CoarseDirt>();
        }
    }
}
