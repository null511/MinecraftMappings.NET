using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaFenceGateWallOpen : JavaBlockModel
    {
        public AcaciaFenceGateWallOpen() : base("Acacia Fence Gate, Wall Open")
        {
            AddVersion("acacia_fence_gate_wall_open", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_fence_gate_wall_open")
                .AddTexture("texture", "block/acacia_planks");
        }
    }
}
