using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Barrel : JavaModelData
    {
        public Barrel() : base("Barrel")
        {
            AddVersion("barrel", "1.14")
                .WithPath("models/block")
                .WithParent("block/cube_bottom_top")
                .AddTexture("top", "block/barrel_top")
                .AddTexture("bottom", "block/barrel_bottom")
                .AddTexture("side", "block/barrel_side");
        }
    }
}
