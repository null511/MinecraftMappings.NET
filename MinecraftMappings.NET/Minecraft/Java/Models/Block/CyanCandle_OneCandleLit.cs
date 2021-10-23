using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CyanCandle_OneCandleLit : JavaBlockModel
    {
        public CyanCandle_OneCandleLit() : base("Cyan Candle, One Candle Lit")
        {
            AddVersion("cyan_candle_one_candle_lit", "1.17")
                .WithPath("models/block")
                .WithParent("block/template_candle")
                .AddTexture("all", "block/cyan_candle_lit");
        }
    }
}
