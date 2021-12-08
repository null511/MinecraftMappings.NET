using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SunflowerFront : JavaBlockTexture
    {
        public SunflowerFront() : base("Sunflower Front")
        {
            AddVersion("sunflower_front");
                //.WithDefaultModel<Java.Models.Block.SunflowerFront>()
                //.MapsToBedrockBlock<BedrockBlocks.SunflowerFront>();
        }
    }
}
