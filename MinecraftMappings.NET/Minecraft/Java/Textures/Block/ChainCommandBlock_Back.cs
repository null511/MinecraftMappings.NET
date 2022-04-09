using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ChainCommandBlock_Back : JavaBlockTexture
    {
        public ChainCommandBlock_Back() : base("Chain Command Block, Back")
        {
            AddVersion("chain_command_block_back")
                .WithDefaultModel<Java.Models.Block.ChainCommandBlock>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CommandBlockBack>();
        }
    }
}
