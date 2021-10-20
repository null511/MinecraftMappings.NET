using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlackStainedGlassPaneTop : JavaBlockTexture
    {
        public BlackStainedGlassPaneTop() : base("Black Stained Glass Pane, Top")
        {
            AddVersion("black_stained_glass_pane_top")
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlassPaneTopBlack>();
        }
    }
}
