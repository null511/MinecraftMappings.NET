using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class TubeCoralBlock : JavaBlockModel
    {
        public TubeCoralBlock() : base("Tube Coral Block")
        {
            AddVersion("tube_coral_block", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/tube_coral_block");
        }
    }
}
