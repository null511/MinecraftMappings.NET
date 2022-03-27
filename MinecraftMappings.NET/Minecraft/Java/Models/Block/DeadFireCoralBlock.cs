using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DeadFireCoralBlock : JavaBlockModel
    {
        public DeadFireCoralBlock() : base("Dead Fire Coral Block")
        {
            AddVersion("dead_fire_coral_block", "1.14")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/dead_fire_coral_block");
        }
    }
}
