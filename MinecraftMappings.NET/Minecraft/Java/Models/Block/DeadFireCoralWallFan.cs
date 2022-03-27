using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DeadFireCoralWallFan : JavaBlockModel
    {
        public DeadFireCoralWallFan() : base("Dead Fire Coral Wall Fan")
        {
            AddVersion("dead_fire_coral_wall_fan", "1.14")
                .WithPath("models/block")
                .WithParent("block/coral_wall_fan")
                .AddTexture("fan", "block/dead_fire_coral_fan");
        }
    }
}
