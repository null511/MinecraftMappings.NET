using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaSlabTop : JavaBlockModel
    {
        public AcaciaSlabTop() : base("Acacia Slab, Top")
        {
            AddVersion("acacia_slab_top", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/slab_top")
                .AddTexture("top", "block/acacia_planks")
                .AddTexture("bottom", "block/acacia_planks")
                .AddTexture("side", "block/acacia_planks");
        }
    }
}
