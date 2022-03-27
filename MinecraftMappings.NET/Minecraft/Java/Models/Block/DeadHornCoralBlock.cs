using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DeadHornCoralBlock : JavaBlockModel
    {
        public DeadHornCoralBlock() : base("Dead Horn Coral Block")
        {
            AddVersion("dead_horn_coral_block", "1.14")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/dead_horn_coral_block");
        }
    }
}
