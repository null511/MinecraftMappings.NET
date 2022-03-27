using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DeadBrainCoralWallFan : JavaBlockModel
    {
        public DeadBrainCoralWallFan() : base("Dead Brain Coral Wall Fan")
        {
            AddVersion("dead_brain_coral_wall_fan", "1.14")
                .WithPath("models/block")
                .WithParent("block/coral_wall_fan")
                .AddTexture("fan", "block/dead_brain_coral_fan");
        }
    }
}
