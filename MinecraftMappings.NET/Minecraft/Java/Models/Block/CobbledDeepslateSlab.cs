using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CobbledDeepslateSlab : JavaBlockModel
    {
        public CobbledDeepslateSlab() : base("Cobbled Deepslate Slab")
        {
            AddVersion("cobbled_deepslate_slab", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/slab")
                .AddTexture("bottom", "block/cobbled_deepslate")
                .AddTexture("top", "block/cobbled_deepslate")
                .AddTexture("side", "block/cobbled_deepslate");
        }
    }
}
