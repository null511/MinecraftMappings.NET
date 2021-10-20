using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaSlab : JavaBlockModel
    {
        public AcaciaSlab() : base("Acacia Slab")
        {
            AddVersion("acacia_slab", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/slab")
                .AddTexture("top", "block/acacia_planks")
                .AddTexture("bottom", "block/acacia_planks")
                .AddTexture("side", "block/acacia_planks");
        }
    }
}
