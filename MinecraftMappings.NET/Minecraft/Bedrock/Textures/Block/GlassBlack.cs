using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class GlassBlack : BedrockBlockTexture
    {
        public GlassBlack() : base("Glass Black")
        {
            AddVersion("glass_black")
                .MapsToJavaBlock<Java.Textures.Block.BlackStainedGlass>();
        }
    }
}
