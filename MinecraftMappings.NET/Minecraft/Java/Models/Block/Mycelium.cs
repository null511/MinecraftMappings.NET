using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Mycelium : JavaBlockModel
    {
        public Mycelium() : base("Mycelium")
        {
            AddVersion("mycelium", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_bottom_top")
                .AddTexture("top", "block/mycelium_top")
                .AddTexture("bottom", "block/dirt")
                .AddTexture("side", "block/mycelium_side");
        }
    }
}
