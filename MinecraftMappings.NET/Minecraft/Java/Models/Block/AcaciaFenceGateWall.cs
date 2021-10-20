using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaFenceGateWall : JavaBlockModel
    {
        public AcaciaFenceGateWall() : base("Acacia Fence Gate, Wall")
        {
            AddVersion("acacia_fence_gate_wall", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_fence_gate_wall")
                .AddTexture("texture", "block/acacia_planks");
        }
    }
}
