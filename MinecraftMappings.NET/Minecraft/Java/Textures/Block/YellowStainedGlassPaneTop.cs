using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class YellowStainedGlassPaneTop : JavaBlockTexture
    {
        public YellowStainedGlassPaneTop() : base("Yellow Stained Glass Pane, Top")
        {
            AddVersion("yellow_stained_glass_pane_top")
                .WithDefaultModel<Java.Models.Block.YellowStainedGlassPane>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlassPaneTopYellow>();
        }
    }
}
