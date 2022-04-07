using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class GlassBlue : BedrockBlockTexture
    {
        public GlassBlue() : base("Glass Blue")
        {
            AddVersion("glass_blue")
                .MapsToJavaBlock<Java.Textures.Block.BlueStainedGlass>();
        }
    }
}
