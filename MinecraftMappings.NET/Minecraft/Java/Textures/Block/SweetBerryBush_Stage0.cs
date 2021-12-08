using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SweetBerryBush_Stage0 : JavaBlockTexture
    {
        public SweetBerryBush_Stage0() : base("Sweet Berry Bush, Stage 0")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("sweet_berry_bush_stage0");
                //.WithDefaultModel<Java.Models.Block.SweetBerryBush_Stage0>()
                //.MapsToBedrockBlock<BedrockBlocks.SweetBerryBush_Stage0>();
        }
    }
}
