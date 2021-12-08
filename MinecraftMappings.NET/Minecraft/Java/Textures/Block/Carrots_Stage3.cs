using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Carrots_Stage3 : JavaBlockTexture
    {
        public Carrots_Stage3() : base("Carrots, Stage 3")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("carrots_stage3")
                .WithDefaultModel<Java.Models.Block.Carrots_Stage3>();
                //.MapsToBedrockBlock<BedrockBlocks.Carrots_Stage3>();
        }
    }
}
