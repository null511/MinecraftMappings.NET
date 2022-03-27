using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class FireCoralFan : JavaBlockModel
    {
        public FireCoralFan() : base("Fire Coral Fan")
        {
            AddVersion("fire_coral_fan", "1.14")
                .WithPath("models/block")
                .WithParent("block/coral_fan")
                .AddTexture("fan", "block/fire_coral_fan");
        }
    }
}
