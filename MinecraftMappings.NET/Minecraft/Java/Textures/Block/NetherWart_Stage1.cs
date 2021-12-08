using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class NetherWart_Stage1 : JavaBlockTexture
    {
        public NetherWart_Stage1() : base("Nether Wart, Stage 1")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("nether_wart_stage1");
                //.WithDefaultModel<Java.Models.Block.NetherWart_Stage1>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.NetherWart_Stage1>();
        }
    }
}
