using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ChainCommandBlock_Conditional : JavaBlockTexture
    {
        public ChainCommandBlock_Conditional() : base("Chain Command Block, Conditional")
        {
            AddVersion("chain_command_block_conditional")
                .WithDefaultModel<Java.Models.Block.ChainCommandBlock_Conditional>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CommandBlockBack>();
        }
    }
}
