using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WhiteStainedGlassPaneTop : JavaBlockTexture
    {
        public WhiteStainedGlassPaneTop() : base("White Stained Glass Pane, Top")
        {
            AddVersion("white_stained_glass_pane_top")
                .WithDefaultModel<Java.Models.Block.WhiteStainedGlassPane>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlassPaneTopWhite>();
        }
    }
}
