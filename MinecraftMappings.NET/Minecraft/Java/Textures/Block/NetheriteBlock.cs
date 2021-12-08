using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class NetheriteBlock : JavaBlockTexture
    {
        public NetheriteBlock() : base("Netherite Block")
        {
            AddVersion("netherite_block");
                //.WithDefaultModel<Java.Models.Block.NetheriteBlock>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.NetheriteBlock>();
        }
    }
}
