using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class StoneSlab : JavaBlockModel
    {
        public StoneSlab() : base("Stone Slab")
        {
            AddVersion("stone_slab", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/slab")
                .AddTexture("top", "block/stone")
                .AddTexture("bottom", "block/stone")
                .AddTexture("side", "block/stone");
        }
    }
}
