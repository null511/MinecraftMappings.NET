using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Wheat_Stage1 : JavaBlockTexture
    {
        public Wheat_Stage1() : base("Wheat, Stage 1")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("wheat_stage1")
                .WithDefaultModel<Java.Models.Block.Wheat_Stage1>();
                //.MapsToBedrockBlock<BedrockBlocks.Wheat_Stage1>();
        }
    }
}
