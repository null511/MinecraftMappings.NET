using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DeadBubbleCoralBlock : JavaBlockModel
    {
        public DeadBubbleCoralBlock() : base("Dead Bubble Coral Block")
        {
            AddVersion("dead_bubble_coral_block", "1.14")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/dead_bubble_coral_block");
        }
    }
}
