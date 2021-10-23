using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Tnt : JavaBlockModel
    {
        public Tnt() : base("TNT")
        {
            AddVersion("tnt", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_bottom_top")
                .AddTexture("top", "block/tnt_top")
                .AddTexture("bottom", "block/tnt_bottom")
                .AddTexture("side", "block/tnt_side");
        }
    }
}
