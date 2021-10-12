using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Allium : JavaModelData
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
