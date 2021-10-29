using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class RoseBush : JavaBlockModel
    {
        public RoseBush() : base("Rose Bush")
        {
            AddVersion("rose_bush", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/tall_cross")
                .AddTexture("cross_top", "block/rose_bush_top")
                .AddTexture("cross_bottom", "block/rose_bush_bottom");
        }
    }
}
