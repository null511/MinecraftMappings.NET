using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class RedCandle_OneCandle_Lit : JavaBlockModel
    {
        public RedCandle_OneCandle_Lit() : base("Red Candle, One Candle, Lit")
        {
            AddVersion("red_candle_one_candle_lit", "1.17")
                .WithPath("models/block")
                .WithParent("block/template_candle")
                .AddTexture("all", "block/red_candle_lit");
        }
    }
}
