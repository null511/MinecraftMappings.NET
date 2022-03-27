using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DeadBrainCoralFan : JavaBlockModel
    {
        public DeadBrainCoralFan() : base("Dead Brain Coral Fan")
        {
            AddVersion("dead_brain_coral_fan", "1.14")
                .WithPath("models/block")
                .WithParent("block/coral_fan")
                .AddTexture("fan", "block/dead_brain_coral_fan");
        }
    }
}
