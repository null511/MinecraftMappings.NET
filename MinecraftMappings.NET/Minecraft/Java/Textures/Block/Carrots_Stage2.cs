using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Carrots_Stage2 : JavaBlockTexture
    {
        public Carrots_Stage2() : base("Carrots, Stage 2")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("carrots_stage2")
                .WithDefaultModel<Java.Models.Block.Carrots_Stage2>();
                //.MapsToBedrockBlock<BedrockBlocks.Carrots_Stage2>();
        }
    }
}
