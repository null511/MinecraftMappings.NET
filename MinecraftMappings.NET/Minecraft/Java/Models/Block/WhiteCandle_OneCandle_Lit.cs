using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WhiteCandle_OneCandle_Lit : JavaBlockModel
    {
        public WhiteCandle_OneCandle_Lit() : base("White Candle, One Candle, Lit")
        {
            AddVersion("white_candle_one_candle_lit", "1.17")
                .WithPath("models/block")
                .WithParent("block/template_candle")
                .AddTexture("all", "block/white_candle_lit");
        }
    }
}
