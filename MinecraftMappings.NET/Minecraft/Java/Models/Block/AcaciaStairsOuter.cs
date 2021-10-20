using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaStairsOuter : JavaBlockModel
    {
        public AcaciaStairsOuter() : base("Acacia Stairs, Outer")
        {
            AddVersion("acacia_stairs_outer", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/outer_stairs")
                .AddTexture("top", "block/acacia_planks")
                .AddTexture("bottom", "block/acacia_planks")
                .AddTexture("side", "block/acacia_planks");
        }
    }
}
