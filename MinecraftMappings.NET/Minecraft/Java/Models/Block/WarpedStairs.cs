using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WarpedStairs : JavaBlockModel
    {
        public WarpedStairs() : base("Warped Stairs")
        {
            AddVersion("warped_stairs", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/stairs")
                .AddTexture("top", "block/warped_planks")
                .AddTexture("bottom", "block/warped_planks")
                .AddTexture("side", "block/warped_planks");
        }
    }
}
