using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlueStainedGlassPaneTop : JavaBlockTexture
    {
        public BlueStainedGlassPaneTop() : base("Blue Stained Glass Pane, Top")
        {
            AddVersion("blue_stained_glass_pane_top")
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlassPaneTopBlue>();
        }
    }
}
