using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class ChiseledNetherBricks : JavaBlockModel
    {
        public ChiseledNetherBricks() : base("Chiseled Nether Bricks")
        {
            AddVersion("chiseled_nether_bricks", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/chiseled_nether_bricks");
        }
    }
}
