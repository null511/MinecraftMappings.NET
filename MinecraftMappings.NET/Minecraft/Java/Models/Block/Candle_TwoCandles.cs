using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Candle_TwoCandles : JavaBlockModel
    {
        public Candle_TwoCandles() : base("Candle, Two Candles")
        {
            AddVersion("candle_two_candles", "1.17")
                .WithPath("models/block")
                .WithParent("block/template_two_candles")
                .AddTexture("all", "block/candle");
        }
    }
}
