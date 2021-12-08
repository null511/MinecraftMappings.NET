using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Wheat_Stage5 : JavaBlockTexture
    {
        public Wheat_Stage5() : base("Wheat, Stage 5")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("wheat_stage5");
                //.WithDefaultModel<Java.Models.Block.Wheat_Stage5>()
                //.MapsToBedrockBlock<BedrockBlocks.Wheat_Stage5>();
        }
    }
}
