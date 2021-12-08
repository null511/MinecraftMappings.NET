using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class SeaLantern : JavaBlockModel
    {
        public SeaLantern() : base("Sea Lantern")
        {
            AddVersion("sea_lantern", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/sea_lantern");
        }
    }
}
