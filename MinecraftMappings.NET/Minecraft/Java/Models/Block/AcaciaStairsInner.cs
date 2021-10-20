using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaStairsInner : JavaBlockModel
    {
        public AcaciaStairsInner() : base("Acacia Stairs, Inner")
        {
            AddVersion("acacia_stairs_inner", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/inner_stairs")
                .AddTexture("top", "block/acacia_planks")
                .AddTexture("bottom", "block/acacia_planks")
                .AddTexture("side", "block/acacia_planks");
        }
    }
}
