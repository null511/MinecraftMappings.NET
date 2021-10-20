using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaFenceGate : JavaBlockModel
    {
        public AcaciaFenceGate() : base("Acacia Fence Gate")
        {
            AddVersion("acacia_fence_gate", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_fence_gate")
                .AddTexture("texture", "block/acacia_planks");
        }
    }
}
