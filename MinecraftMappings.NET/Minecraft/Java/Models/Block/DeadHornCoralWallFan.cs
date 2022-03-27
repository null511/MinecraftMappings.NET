using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DeadHornCoralWallFan : JavaBlockModel
    {
        public DeadHornCoralWallFan() : base("Dead Horn Coral Wall Fan")
        {
            AddVersion("dead_horn_coral_wall_fan", "1.14")
                .WithPath("models/block")
                .WithParent("block/coral_wall_fan")
                .AddTexture("fan", "block/dead_horn_coral_fan");
        }
    }
}
