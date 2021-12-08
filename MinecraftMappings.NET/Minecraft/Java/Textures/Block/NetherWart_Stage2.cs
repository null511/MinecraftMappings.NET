using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class NetherWart_Stage2 : JavaBlockTexture
    {
        public NetherWart_Stage2() : base("Nether Wart, Stage 2")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("nether_wart_stage2");
                //.WithDefaultModel<Java.Models.Block.NetherWart_Stage2>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.NetherWart_Stage2>();
        }
    }
}
