using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class RedCandle_OneCandle : JavaBlockModel
    {
        public RedCandle_OneCandle() : base("Red Candle, One Candle")
        {
            AddVersion("red_candle_one_candle", "1.17")
                .WithPath("models/block")
                .WithParent("block/template_candle")
                .AddTexture("all", "block/red_candle");
        }
    }
}
