using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ChainCommandBlock_Front : JavaBlockTexture
    {
        public ChainCommandBlock_Front() : base("Chain Command Block, Front")
        {
            AddVersion("chain_command_block_front")
                .WithDefaultModel<Java.Models.Block.ChainCommandBlock>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CommandBlockBack>();
        }
    }
}
