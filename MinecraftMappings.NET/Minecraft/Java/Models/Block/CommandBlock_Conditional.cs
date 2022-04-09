using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CommandBlock_Conditional : JavaBlockModel
    {
        public CommandBlock_Conditional() : base("Command Block, Conditional")
        {
            AddVersion("command_block_conditional", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_command_block")
                .AddTexture("front", "block/command_block_front")
                .AddTexture("back", "block/command_block_back")
                .AddTexture("side", "block/command_block_conditional");
        }
    }
}
