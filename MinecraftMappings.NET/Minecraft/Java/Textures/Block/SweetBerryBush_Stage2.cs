using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SweetBerryBush_Stage2 : JavaBlockTexture
    {
        public SweetBerryBush_Stage2() : base("Sweet Berry Bush, Stage 2")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("sweet_berry_bush_stage2");
                //.WithDefaultModel<Java.Models.Block.SweetBerryBush_Stage2>()
                //.MapsToBedrockBlock<BedrockBlocks.SweetBerryBush_Stage2>();
        }
    }
}
