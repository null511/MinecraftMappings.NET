using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class OakLeaves : JavaBlockModel
    {
        public OakLeaves() : base("Oak Leaves")
        {
            AddVersion("oak_leaves", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/leaves")
                .AddTexture("all", "block/oak_leaves");
        }
    }
}
