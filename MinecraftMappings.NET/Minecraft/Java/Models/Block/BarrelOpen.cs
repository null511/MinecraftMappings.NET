using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BarrelOpen : JavaBlockModel
    {
        public BarrelOpen() : base("Barrel, Open")
        {
            AddVersion("barrel_open", "1.14")
                .WithPath("models/block")
                .WithParent("block/cube_bottom_top")
                .AddTexture("top", "block/barrel_top_open")
                .AddTexture("bottom", "block/barrel_bottom")
                .AddTexture("side", "block/barrel_side");
        }
    }
}
