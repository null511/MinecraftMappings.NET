using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SweetBerryBush_Stage3 : JavaBlockTexture
    {
        public SweetBerryBush_Stage3() : base("Sweet Berry Bush, Stage 3")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("sweet_berry_bush_stage3");
                //.WithDefaultModel<Java.Models.Block.SweetBerryBush_Stage3>()
                //.MapsToBedrockBlock<BedrockBlocks.SweetBerryBush_Stage3>();
        }
    }
}
