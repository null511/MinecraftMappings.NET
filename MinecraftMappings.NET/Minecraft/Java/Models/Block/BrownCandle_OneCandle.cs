using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BrownCandle_OneCandle : JavaBlockModel
    {
        public BrownCandle_OneCandle() : base("Brown Candle, One Candle")
        {
            AddVersion("brown_candle_one_candle", "1.17")
                .WithPath("models/block")
                .WithParent("block/template_candle")
                .AddTexture("all", "block/brown_candle");
        }
    }
}
