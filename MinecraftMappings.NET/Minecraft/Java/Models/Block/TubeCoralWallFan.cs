using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class TubeCoralWallFan : JavaBlockModel
    {
        public TubeCoralWallFan() : base("Tube Coral Wall Fan")
        {
            AddVersion("tube_coral_wall_fan", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/coral_wall_fan")
                .AddTexture("fan", "block/tube_coral_fan");
        }
    }
}
