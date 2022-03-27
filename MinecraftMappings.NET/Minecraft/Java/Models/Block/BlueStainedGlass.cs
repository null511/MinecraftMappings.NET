using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlueStainedGlass : JavaBlockModel
    {
        public BlueStainedGlass() : base("Blue Stained Glass")
        {
            AddVersion("blue_stained_glass", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/blue_stained_glass");
        }
    }
}
