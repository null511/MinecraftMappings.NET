using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BubbleCoralBlock : JavaBlockModel
    {
        public BubbleCoralBlock() : base("Bubble Coral Block")
        {
            AddVersion("bubble_coral_block", "1.14")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/bubble_coral_block");
        }
    }
}
