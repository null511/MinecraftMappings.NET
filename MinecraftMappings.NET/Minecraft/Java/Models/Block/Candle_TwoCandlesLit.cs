using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Candle_TwoCandlesLit : JavaBlockModel
    {
        public Candle_TwoCandlesLit() : base("Candle, Two Candles Lit")
        {
            AddVersion("candle_two_candles_lit", "1.17")
                .WithPath("models/block")
                .WithParent("block/template_two_candles")
                .AddTexture("all", "block/candle_lit");
        }
    }
}
