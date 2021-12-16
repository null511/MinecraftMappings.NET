using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BubbleCoral : JavaBlockModel
    {
        public BubbleCoral() : base("Bubble Coral")
        {
            AddVersion("bubble_coral", "1.14")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/bubble_coral");
        }
    }
}
