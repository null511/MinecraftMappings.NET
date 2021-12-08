using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class NetherWart_Stage0 : JavaBlockTexture
    {
        public NetherWart_Stage0() : base("Nether Wart, Stage 0")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("nether_wart_stage0");
                //.WithDefaultModel<Java.Models.Block.NetherWart_Stage0>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.NetherWart_Stage0>();
        }
    }
}
