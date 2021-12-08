using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlueStainedGlassPaneTop : JavaBlockTexture
    {
        public BlueStainedGlassPaneTop() : base("Blue Stained Glass Pane, Top")
        {
            AddVersion("blue_stained_glass_pane_top")
                .WithDefaultModel<Java.Models.Block.BlueStainedGlassPane>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlassPaneTopBlue>();
        }
    }
}
