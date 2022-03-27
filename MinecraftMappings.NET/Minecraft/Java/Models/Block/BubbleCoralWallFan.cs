using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BubbleCoralWallFan : JavaBlockModel
    {
        public BubbleCoralWallFan() : base("Bubble Coral Wall Fan")
        {
            AddVersion("bubble_coral_wall_fan", "1.14")
                .WithPath("models/block")
                .WithParent("block/coral_wall_fan")
                .AddTexture("fan", "block/bubble_coral_fan");
        }
    }
}
