using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class TintedGlass : JavaBlockModel
    {
        public TintedGlass() : base("Tinted Glass")
        {
            AddVersion("tinted_glass", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/tinted_glass");
        }
    }
}
