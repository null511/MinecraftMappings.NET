using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Carrots_Stage1 : JavaBlockTexture
    {
        public Carrots_Stage1() : base("Carrots, Stage 1")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("carrots_stage1")
                .WithDefaultModel<Java.Models.Block.Carrots_Stage1>();
                //.MapsToBedrockBlock<BedrockBlocks.Carrots_Stage1>();
        }
    }
}
