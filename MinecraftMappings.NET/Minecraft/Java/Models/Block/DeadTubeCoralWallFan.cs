using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DeadTubeCoralWallFan : JavaBlockModel
    {
        public DeadTubeCoralWallFan() : base("Dead Tube Coral Wall Fan")
        {
            AddVersion("dead_tube_coral_wall_fan", "1.14")
                .WithPath("models/block")
                .WithParent("block/coral_wall_fan")
                .AddTexture("fan", "block/dead_tube_coral_fan");
        }
    }
}
