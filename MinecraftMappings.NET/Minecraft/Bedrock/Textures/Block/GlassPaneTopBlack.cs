using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class GlassPaneTopBlack : BedrockBlockTexture
    {
        public GlassPaneTopBlack() : base("Glass Pane Top, Black")
        {
            AddVersion("glass_pane_top_black")
                .MapsToJavaBlock<Java.Textures.Block.BlackStainedGlassPaneTop>();
        }
    }
}
