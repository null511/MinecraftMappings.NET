using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WarpedRoots : JavaBlockModel
    {
        public WarpedRoots() : base("Warped Roots")
        {
            AddVersion("warped_roots", "1.16")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/warped_roots");
        }
    }
}
