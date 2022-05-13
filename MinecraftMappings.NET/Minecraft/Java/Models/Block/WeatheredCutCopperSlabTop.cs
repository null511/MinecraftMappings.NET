using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WeatheredCutCopperSlabTop : JavaBlockModel
    {
        public WeatheredCutCopperSlabTop() : base("Weathered Cut Copper Slab, Top")
        {
            AddVersion("weathered_cut_copper_slab_top", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/slab_top")
                .AddTexture("bottom", "block/weathered_cut_copper")
                .AddTexture("top", "block/weathered_cut_copper")
                .AddTexture("side", "block/weathered_cut_copper");
        }
    }
}
