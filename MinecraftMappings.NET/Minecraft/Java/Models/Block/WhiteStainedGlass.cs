using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WhiteStainedGlass : JavaBlockModel
    {
        public WhiteStainedGlass() : base("White Stained Glass")
        {
            AddVersion("white_stained_glass", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/white_stained_glass");
        }
    }
}
