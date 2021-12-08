using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SunflowerTop : JavaBlockTexture
    {
        public SunflowerTop() : base("Sunflower Top")
        {
            AddVersion("sunflower_top");
                //.WithDefaultModel<Java.Models.Block.SunflowerTop>()
                //.MapsToBedrockBlock<BedrockBlocks.SunflowerTop>();
        }
    }
}
