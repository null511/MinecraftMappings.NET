using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DeadBrainCoralBlock : JavaBlockModel
    {
        public DeadBrainCoralBlock() : base("Dead Brain Coral Block")
        {
            AddVersion("dead_brain_coral_block", "1.14")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/dead_brain_coral_block");
        }
    }
}
