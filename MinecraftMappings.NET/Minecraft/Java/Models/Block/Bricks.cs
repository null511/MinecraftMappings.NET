using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Bricks : JavaBlockModel
    {
        public Bricks() : base("Bricks")
        {
            AddVersion("bricks", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/bricks");
        }
    }
}
