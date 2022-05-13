using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WeatheredCutCopperSlab : JavaBlockModel
    {
        public WeatheredCutCopperSlab() : base("Weathered Cut Copper Slab")
        {
            AddVersion("weathered_cut_copper_slab", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/slab")
                .AddTexture("bottom", "block/weathered_cut_copper")
                .AddTexture("top", "block/weathered_cut_copper")
                .AddTexture("side", "block/weathered_cut_copper");
        }
    }
}
