using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SunflowerBottom : JavaBlockTexture
    {
        public SunflowerBottom() : base("Sunflower Bottom")
        {
            AddVersion("sunflower_bottom");
                //.WithDefaultModel<Java.Models.Block.SunflowerBottom>()
                //.MapsToBedrockBlock<BedrockBlocks.SunflowerBottom>();
        }
    }
}
