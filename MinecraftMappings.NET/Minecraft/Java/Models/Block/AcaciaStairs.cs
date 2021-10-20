using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaStairs : JavaBlockModel
    {
        public AcaciaStairs() : base("Acacia Stairs")
        {
            AddVersion("acacia_stairs", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/stairs")
                .AddTexture("top", "block/acacia_planks")
                .AddTexture("bottom", "block/acacia_planks")
                .AddTexture("side", "block/acacia_planks");
        }
    }
}
