using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DeadHornCoralFan : JavaBlockModel
    {
        public DeadHornCoralFan() : base("Dead Horn Coral Fan")
        {
            AddVersion("dead_horn_coral_fan", "1.14")
                .WithPath("models/block")
                .WithParent("block/coral_fan")
                .AddTexture("fan", "block/dead_horn_coral_fan");
        }
    }
}
