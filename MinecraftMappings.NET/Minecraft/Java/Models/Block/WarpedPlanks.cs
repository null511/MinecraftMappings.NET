using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WarpedPlanks : JavaBlockModel
    {
        public WarpedPlanks() : base("Warped Planks")
        {
            AddVersion("warped_planks", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/warped_planks");
        }
    }
}
