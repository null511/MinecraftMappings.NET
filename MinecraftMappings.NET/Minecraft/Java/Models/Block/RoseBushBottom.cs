using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class RoseBushBottom : JavaBlockModel
    {
        public RoseBushBottom() : base("Rose Bush Bottom")
        {
            AddVersion("rose_bush_bottom", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/rose_bush_bottom");
        }
    }
}
