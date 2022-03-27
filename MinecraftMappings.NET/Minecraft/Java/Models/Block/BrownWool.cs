using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BrownWool : JavaBlockModel
    {
        public BrownWool() : base("Brown Wool")
        {
            AddVersion("brown_wool", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/brown_wool");
        }
    }
}
