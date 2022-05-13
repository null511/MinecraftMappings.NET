using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WarpedFenceGate : JavaBlockModel
    {
        public WarpedFenceGate() : base("Warped Fence Gate")
        {
            AddVersion("warped_fence_gate", "1.16")
                .WithPath("models/block")
                .WithParent("block/template_fence_gate")
                .AddTexture("texture", "block/warped_planks");
        }
    }
}
