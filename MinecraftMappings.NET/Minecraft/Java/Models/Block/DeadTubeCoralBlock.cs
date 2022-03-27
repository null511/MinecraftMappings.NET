using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DeadTubeCoralBlock : JavaBlockModel
    {
        public DeadTubeCoralBlock() : base("Dead Tube Coral Block")
        {
            AddVersion("dead_tube_coral_block", "1.14")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/dead_tube_coral_block");
        }
    }
}
