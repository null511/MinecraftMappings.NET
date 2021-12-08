using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Seagrass : JavaBlockTexture
    {
        public Seagrass() : base("Seagrass")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("seagrass");
                //.WithDefaultModel<Java.Models.Block.Seagrass>()
                //.MapsToBedrockBlock<BedrockBlocks.Seagrass>();
        }
    }
}
