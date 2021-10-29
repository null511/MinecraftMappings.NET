using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DarkOakLeaves : JavaBlockModel
    {
        public DarkOakLeaves() : base("Dark Oak Leaves")
        {
            AddVersion("dark_oak_leaves", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/leaves")
                .AddTexture("all", "block/dark_oak_leaves");
        }
    }
}
