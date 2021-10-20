using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaFenceSide : JavaBlockModel
    {
        public AcaciaFenceSide() : base("Acacia Fence Side")
        {
            AddVersion("acacia_fence_side", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/fence_side")
                .AddTexture("texture", "block/acacia_planks");
        }
    }
}
