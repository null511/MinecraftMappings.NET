using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class HangingRoots : JavaBlockModel
    {
        public HangingRoots() : base("Hanging Roots")
        {
            AddVersion("hanging_roots", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/hanging_roots");
        }
    }
}
