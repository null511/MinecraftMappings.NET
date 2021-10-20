using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WhiteCandle_OneCandle : JavaBlockModel
    {
        public WhiteCandle_OneCandle() : base("White Candle, One Candle")
        {
            AddVersion("white_candle_one_candle", "1.17")
                .WithPath("models/block")
                .WithParent("block/template_candle")
                .AddTexture("all", "block/white_candle");
        }
    }
}
