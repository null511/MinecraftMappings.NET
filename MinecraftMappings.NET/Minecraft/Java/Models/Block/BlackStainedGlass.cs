using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlackStainedGlass : JavaBlockModel
    {
        public BlackStainedGlass() : base("Black Stained Glass")
        {
            AddVersion("black_stained_glass", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/black_stained_glass");
        }
    }
}
