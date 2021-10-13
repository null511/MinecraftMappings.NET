using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class GlassPaneTopBlack : BedrockBlockTexture
    {
        public GlassPaneTopBlack() : base("Glass Pane Top, Black")
        {
            AddVersion("glass_pane_top_black")
                .MapsToJavaBlock<BlackStainedGlassPaneTop>();
        }
    }
}
