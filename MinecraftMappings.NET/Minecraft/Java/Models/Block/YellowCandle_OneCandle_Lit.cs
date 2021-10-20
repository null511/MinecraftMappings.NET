using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class YellowCandle_OneCandle_Lit : JavaBlockModel
    {
        public YellowCandle_OneCandle_Lit() : base("Yellow Candle, One Candle, Lit")
        {
            AddVersion("yellow_candle_one_candle_lit", "1.17")
                .WithPath("models/block")
                .WithParent("block/template_candle")
                .AddTexture("all", "block/yellow_candle_lit");
        }
    }
}
