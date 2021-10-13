using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlackStainedGlassPaneTop : JavaBlockTexture
    {
        public BlackStainedGlassPaneTop() : base("Black Stained Glass Pane, Top")
        {
            AddVersion("black_stained_glass_pane_top")
                .MapsToBedrockBlock<BedrockBlocks.GlassPaneTopBlack>();
        }
    }
}
