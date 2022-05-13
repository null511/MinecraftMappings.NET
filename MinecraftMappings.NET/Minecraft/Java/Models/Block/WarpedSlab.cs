using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WarpedSlab : JavaBlockModel
    {
        public WarpedSlab() : base("Warped Slab")
        {
            AddVersion("warped_slab", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/slab")
                .AddTexture("top", "block/warped_planks")
                .AddTexture("bottom", "block/warped_planks")
                .AddTexture("side", "block/warped_planks");
        }
    }
}
