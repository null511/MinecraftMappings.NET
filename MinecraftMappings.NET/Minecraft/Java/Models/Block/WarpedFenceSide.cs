using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WarpedFenceSide : JavaBlockModel
    {
        public WarpedFenceSide() : base("Warped Fence Side")
        {
            AddVersion("warped_fence_side", "1.16")
                .WithPath("models/block")
                .WithParent("block/fence_side")
                .AddTexture("texture", "block/warped_planks");
        }
    }
}
