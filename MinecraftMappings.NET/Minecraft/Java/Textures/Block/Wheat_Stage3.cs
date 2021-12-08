using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Wheat_Stage3 : JavaBlockTexture
    {
        public Wheat_Stage3() : base("Wheat, Stage 3")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("wheat_stage3");
                //.WithDefaultModel<Java.Models.Block.Wheat_Stage3>()
                //.MapsToBedrockBlock<BedrockBlocks.Wheat_Stage3>();
        }
    }
}
