using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class FireCoralWallFan : JavaBlockModel
    {
        public FireCoralWallFan() : base("Fire Coral Wall Fan")
        {
            AddVersion("fire_coral_wall_fan", "1.14")
                .WithPath("models/block")
                .WithParent("block/coral_wall_fan")
                .AddTexture("fan", "block/fire_coral_fan");
        }
    }
}
