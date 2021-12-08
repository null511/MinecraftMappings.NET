using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Wheat_Stage7 : JavaBlockTexture
    {
        public Wheat_Stage7() : base("Wheat, Stage 7")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("wheat_stage7");
                //.WithDefaultModel<Java.Models.Block.Wheat_Stage7>()
                //.MapsToBedrockBlock<BedrockBlocks.Wheat_Stage7>();
        }
    }
}
