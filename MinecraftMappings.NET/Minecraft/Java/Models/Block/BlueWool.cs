using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlueWool : JavaBlockModel
    {
        public BlueWool() : base("Blue Wool")
        {
            AddVersion("blue_wool", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/blue_wool");
        }
    }
}
