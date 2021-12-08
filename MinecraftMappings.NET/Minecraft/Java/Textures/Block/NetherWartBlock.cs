using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class NetherWartBlock : JavaBlockTexture
    {
        public NetherWartBlock() : base("Nether Wart Block")
        {
            AddVersion("nether_wart_block");
                //.WithDefaultModel<Java.Models.Block.NetherWartBlock>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.NetherWartBlock>();
        }
    }
}
