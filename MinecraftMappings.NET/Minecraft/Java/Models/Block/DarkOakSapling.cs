using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DarkOakSapling : JavaBlockModel
    {
        public DarkOakSapling() : base("Dark Oak Sapling")
        {
            AddVersion("dark_oak_sapling", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/dark_oak_sapling");
        }
    }
}
