using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Bookshelf : JavaBlockModel
    {
        public Bookshelf() : base("Bookshelf")
        {
            AddVersion("bookshelf", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/oak_planks")
                .AddTexture("side", "block/bookshelf");
        }
    }
}
