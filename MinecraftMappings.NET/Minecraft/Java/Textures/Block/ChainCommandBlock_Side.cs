using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ChainCommandBlock_Side : JavaBlockTexture
    {
        public ChainCommandBlock_Side() : base("Chain Command Block, Side")
        {
            AddVersion("chain_command_block_side")
                .WithDefaultModel<Java.Models.Block.ChainCommandBlock>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CommandBlockBack>();
        }
    }
}
