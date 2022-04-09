using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class RepeatingCommandBlock : JavaBlockModel
    {
        public RepeatingCommandBlock() : base("Repeating Command Block")
        {
            AddVersion("repeating_command_block", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_command_block")
                .AddTexture("front", "block/repeating_command_block_front")
                .AddTexture("back", "block/repeating_command_block_back")
                .AddTexture("side", "block/repeating_command_block_side");
        }
    }
}
