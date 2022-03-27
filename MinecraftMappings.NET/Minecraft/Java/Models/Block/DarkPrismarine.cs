using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DarkPrismarine : JavaBlockModel
    {
        public DarkPrismarine() : base("Dark Prismarine")
        {
            AddVersion("dark_prismarine", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/dark_prismarine");
        }
    }
}
