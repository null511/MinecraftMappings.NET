using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WarpedFenceInventory : JavaBlockModel
    {
        public WarpedFenceInventory() : base("Warped Fence Inventory")
        {
            AddVersion("warped_fence_inventory", "1.16")
                .WithPath("models/block")
                .WithParent("block/fence_inventory")
                .AddTexture("texture", "block/warped_planks");
        }
    }
}
