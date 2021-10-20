using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class GlassPaneTopBlue : BedrockBlockTexture
    {
        public GlassPaneTopBlue() : base("Glass Pane Top Blue")
        {
            AddVersion("glass_pane_top_blue")
                .MapsToJavaBlock<BlueStainedGlassPaneTop>();
        }
    }
}
