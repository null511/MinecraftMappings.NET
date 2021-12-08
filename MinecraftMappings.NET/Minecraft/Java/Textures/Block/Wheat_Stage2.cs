using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Wheat_Stage2 : JavaBlockTexture
    {
        public Wheat_Stage2() : base("Wheat, Stage 2")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("wheat_stage2");
                //.WithDefaultModel<Java.Models.Block.Wheat_Stage2>()
                //.MapsToBedrockBlock<BedrockBlocks.Wheat_Stage2>();
        }
    }
}
