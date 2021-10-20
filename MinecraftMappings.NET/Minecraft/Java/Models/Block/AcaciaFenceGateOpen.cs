using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaFenceGateOpen : JavaBlockModel
    {
        public AcaciaFenceGateOpen() : base("Acacia Fence Gate, Open")
        {
            AddVersion("acacia_fence_gate_open", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_fence_gate_open")
                .AddTexture("texture", "block/acacia_planks");
        }
    }
}
