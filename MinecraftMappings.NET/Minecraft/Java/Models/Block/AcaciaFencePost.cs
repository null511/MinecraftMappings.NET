using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaFencePost : JavaBlockModel
    {
        public AcaciaFencePost() : base("Acacia Fence Post")
        {
            AddVersion("acacia_fence_post", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/fence_post")
                .AddTexture("texture", "block/acacia_planks");
        }
    }
}
