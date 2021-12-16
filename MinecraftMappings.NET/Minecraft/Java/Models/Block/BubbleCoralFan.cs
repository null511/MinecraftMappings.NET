using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BubbleCoralFan : JavaBlockModel
    {
        public BubbleCoralFan() : base("Bubble Coral Fan")
        {
            AddVersion("bubble_coral_fan", "1.14")
                .WithPath("models/block")
                .WithParent("block/coral_fan")
                .AddTexture("fan", "block/bubble_coral_fan");
        }
    }
}
