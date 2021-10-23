using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Loom : JavaBlockModel
    {
        public Loom() : base("Loom")
        {
            AddVersion("loom", "1.14")
                .WithPath("models/block")
                .WithParent("block/orientable_with_bottom")
                .AddTexture("top", "block/loom_top")
                .AddTexture("bottom", "block/loom_bottom")
                .AddTexture("side", "block/loom_side")
                .AddTexture("front", "block/loom_front");
        }
    }
}
