using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Allium : JavaBlockModel
    {
        public Allium() : base("Allium")
        {
            AddVersion("allium", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/allium");
        }
    }
}
