using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class SpruceLeaves : JavaModelData
    {
        public SpruceLeaves() : base("Spruce Leaves")
        {
            AddVersion("spruce_leaves", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/leaves")
                .AddTexture("all", "block/spruce_leaves");
        }
    }
}
