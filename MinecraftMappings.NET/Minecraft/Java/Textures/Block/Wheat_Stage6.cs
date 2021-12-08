using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Wheat_Stage6 : JavaBlockTexture
    {
        public Wheat_Stage6() : base("Wheat, Stage 6")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("wheat_stage6");
                //.WithDefaultModel<Java.Models.Block.Wheat_Stage6>()
                //.MapsToBedrockBlock<BedrockBlocks.Wheat_Stage6>();
        }
    }
}
