using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SunflowerBack : JavaBlockTexture
    {
        public SunflowerBack() : base("Sunflower Back")
        {
            AddVersion("sunflower_back");
                //.WithDefaultModel<Java.Models.Block.SunflowerBack>()
                //.MapsToBedrockBlock<BedrockBlocks.SunflowerBack>();
        }
    }
}
