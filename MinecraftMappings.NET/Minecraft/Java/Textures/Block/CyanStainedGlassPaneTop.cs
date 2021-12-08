using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CyanStainedGlassPaneTop : JavaBlockTexture
    {
        public CyanStainedGlassPaneTop() : base("Cyan Stained Glass Pane, Top")
        {
            AddVersion("cyan_stained_glass_pane_top")
                .WithDefaultModel<Java.Models.Block.CyanStainedGlassPane>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlassPaneTopCyan>();
        }
    }
}
