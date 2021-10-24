using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WhiteTulip : JavaBlockModel
    {
        public WhiteTulip() : base("White Tulip")
        {
            AddVersion("white_tulip", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/white_tulip");
        }
    }
}
