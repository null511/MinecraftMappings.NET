using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DeadTubeCoralFan : JavaBlockModel
    {
        public DeadTubeCoralFan() : base("Dead Tube Coral Fan")
        {
            AddVersion("dead_tube_coral_fan", "1.14")
                .WithPath("models/block")
                .WithParent("block/coral_fan")
                .AddTexture("fan", "block/dead_tube_coral_fan");
        }
    }
}
