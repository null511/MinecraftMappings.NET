using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlackWool : JavaBlockModel
    {
        public BlackWool() : base("Black Wool")
        {
            AddVersion("black_wool", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/black_wool");
        }
    }
}
