using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlueStainedGlassPaneTop : JavaBlockTexture
    {
        public BlueStainedGlassPaneTop() : base("Blue Stained Glass Pane, Top")
        {
            AddVersion("blue_stained_glass_pane_top")
                .MapsToBedrockBlock<BedrockBlocks.GlassPaneTopBlue>();
        }
    }
}
