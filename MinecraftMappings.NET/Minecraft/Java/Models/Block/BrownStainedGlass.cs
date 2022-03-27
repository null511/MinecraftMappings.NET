using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BrownStainedGlass : JavaBlockModel
    {
        public BrownStainedGlass() : base("Brown Stained Glass")
        {
            AddVersion("brown_stained_glass", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/brown_stained_glass");
        }
    }
}
