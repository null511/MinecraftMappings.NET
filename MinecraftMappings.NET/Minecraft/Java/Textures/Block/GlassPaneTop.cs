using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GlassPaneTop : JavaBlockTexture
    {
        public GlassPaneTop() : base("Glass Pane Top")
        {
            AddVersion("glass_pane_top");
                //.WithDefaultModel<Java.Models.Block.GlassPane>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlassPaneTop>();
        }
    }
}
