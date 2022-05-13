using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Wheat_Stage0 : JavaBlockTexture
    {
        public Wheat_Stage0() : base("Wheat, Stage 0")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("wheat_stage0")
                .WithDefaultModel<Java.Models.Block.Wheat_Stage0>();
                //.MapsToBedrockBlock<BedrockBlocks.Wheat_Stage0>();
        }
    }
}
