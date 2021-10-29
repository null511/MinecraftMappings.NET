using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlueIce : JavaBlockModel
    {
        public BlueIce() : base("Blue Ice")
        {
            AddVersion("blue_ice", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/blue_ice");
        }
    }
}
