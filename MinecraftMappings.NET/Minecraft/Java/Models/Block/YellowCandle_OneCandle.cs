using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class YellowCandle_OneCandle : JavaBlockModel
    {
        public YellowCandle_OneCandle() : base("Yellow Candle, One Candle")
        {
            AddVersion("yellow_candle_one_candle", "1.17")
                .WithPath("models/block")
                .WithParent("block/template_candle")
                .AddTexture("all", "block/yellow_candle");
        }
    }
}
