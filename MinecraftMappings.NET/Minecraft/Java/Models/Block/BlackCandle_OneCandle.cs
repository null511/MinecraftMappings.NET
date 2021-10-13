using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlackCandle_OneCandle : JavaBlockModel
    {
        public BlackCandle_OneCandle() : base("Black Candle, One Candle")
        {
            AddVersion("black_candle_one_candle", "1.17")
                .WithPath("models/block")
                .WithParent("block/template_candle")
                .AddTexture("all", "block/black_candle");
        }
    }
}
