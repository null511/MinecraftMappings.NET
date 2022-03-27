using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CobblestoneSlab : JavaBlockModel
    {
        public CobblestoneSlab() : base("Cobblestone Slab")
        {
            AddVersion("cobblestone_slab", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/slab")
                .AddTexture("bottom", "block/cobblestone")
                .AddTexture("top", "block/cobblestone")
                .AddTexture("side", "block/cobblestone");
        }
    }
}
