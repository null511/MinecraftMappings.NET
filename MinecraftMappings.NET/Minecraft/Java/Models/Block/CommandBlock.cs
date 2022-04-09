using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CommandBlock : JavaBlockModel
    {
        public CommandBlock() : base("Command Block")
        {
            AddVersion("command_block", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_command_block")
                .AddTexture("front", "block/command_block_front")
                .AddTexture("back", "block/command_block_back")
                .AddTexture("side", "block/command_block_side");
        }
    }
}
