using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WhiteWool : JavaBlockModel
    {
        public WhiteWool() : base("White Wool")
        {
            AddVersion("white_wool", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/white_wool");
        }
    }
}
