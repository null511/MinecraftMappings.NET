using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class ChainCommandBlock : JavaBlockModel
    {
        public ChainCommandBlock() : base("Chain Command Block")
        {
            AddVersion("chain_command_block", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_command_block")
                .AddTexture("front", "block/chain_command_block_front")
                .AddTexture("back", "block/chain_command_block_back")
                .AddTexture("side", "block/chain_command_block_side");
        }
    }
}
