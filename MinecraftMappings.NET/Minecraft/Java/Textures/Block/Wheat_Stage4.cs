using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Wheat_Stage4 : JavaBlockTexture
    {
        public Wheat_Stage4() : base("Wheat, Stage 4")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("wheat_stage4")
                .WithDefaultModel<Java.Models.Block.Wheat_Stage4>();
                //.MapsToBedrockBlock<BedrockBlocks.Wheat_Stage4>();
        }
    }
}
