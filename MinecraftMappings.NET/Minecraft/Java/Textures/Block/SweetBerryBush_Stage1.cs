using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SweetBerryBush_Stage1 : JavaBlockTexture
    {
        public SweetBerryBush_Stage1() : base("Sweet Berry Bush, Stage 1")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("sweet_berry_bush_stage1");
                //.WithDefaultModel<Java.Models.Block.SweetBerryBush_Stage1>()
                //.MapsToBedrockBlock<BedrockBlocks.SweetBerryBush_Stage1>();
        }
    }
}
