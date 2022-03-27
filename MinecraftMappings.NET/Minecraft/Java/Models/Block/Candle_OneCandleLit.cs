using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Candle_OneCandleLit : JavaBlockModel
    {
        public Candle_OneCandleLit() : base("Candle, One Candle Lit")
        {
            AddVersion("candle_one_candle_lit", "1.17")
                .WithPath("models/block")
                .WithParent("block/template_candle")
                .AddTexture("all", "block/candle_lit");
        }
    }
}
