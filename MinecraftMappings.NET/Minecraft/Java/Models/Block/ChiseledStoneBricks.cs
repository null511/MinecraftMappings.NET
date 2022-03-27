using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class ChiseledStoneBricks : JavaBlockModel
    {
        public ChiseledStoneBricks() : base("Chiseled Stone Bricks")
        {
            AddVersion("chiseled_stone_bricks", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/chiseled_stone_bricks");
        }
    }
}
