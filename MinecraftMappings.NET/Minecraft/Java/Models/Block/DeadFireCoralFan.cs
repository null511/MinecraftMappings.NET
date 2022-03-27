using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DeadFireCoralFan : JavaBlockModel
    {
        public DeadFireCoralFan() : base("Dead Fire Coral Fan")
        {
            AddVersion("dead_fire_coral_fan", "1.14")
                .WithPath("models/block")
                .WithParent("block/coral_fan")
                .AddTexture("fan", "block/dead_fire_coral_fan");
        }
    }
}
