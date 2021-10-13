using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BirchLeaves : JavaBlockModel
    {
        public BirchLeaves() : base("Birch Leaves")
        {
            AddVersion("birch_leaves", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/leaves")
                .AddTexture("all", "block/birch_leaves");
        }
    }
}
