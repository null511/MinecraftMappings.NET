using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrownStainedGlassPaneTop : JavaBlockTexture
    {
        public BrownStainedGlassPaneTop() : base("Brown Stained Glass Pane, Top")
        {
            AddVersion("brown_stained_glass_pane_top")
                .WithDefaultModel<Java.Models.Block.BrownStainedGlassPane>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlassPaneTopBrown>();
        }
    }
}
