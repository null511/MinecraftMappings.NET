using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class TubeCoralFan : JavaBlockModel
    {
        public TubeCoralFan() : base("Tube Coral Fan")
        {
            AddVersion("tube_coral_fan", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/coral_fan")
                .AddTexture("fan", "block/tube_coral_fan");
        }
    }
}
