using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WarpedFencePost : JavaBlockModel
    {
        public WarpedFencePost() : base("Warped Fence Post")
        {
            AddVersion("warped_fence_post", "1.16")
                .WithPath("models/block")
                .WithParent("block/fence_post")
                .AddTexture("texture", "block/warped_planks");
        }
    }
}
