using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class ChainCommandBlock_Conditional : JavaBlockModel
    {
        public ChainCommandBlock_Conditional() : base("Chain Command Block, Conditional")
        {
            AddVersion("chain_command_block_conditional", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_command_block")
                .AddTexture("front", "block/chain_command_block_front")
                .AddTexture("back", "block/chain_command_block_back")
                .AddTexture("side", "block/chain_command_block_conditional");
        }
    }
}
