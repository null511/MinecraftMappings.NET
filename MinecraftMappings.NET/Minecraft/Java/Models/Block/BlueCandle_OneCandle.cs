using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlueCandle_OneCandle : JavaBlockModel
    {
        public BlueCandle_OneCandle() : base("Blue Candle, One Candle")
        {
            AddVersion("blue_candle_one_candle", "1.17")
                .WithPath("models/block")
                .WithParent("block/template_candle")
                .AddTexture("all", "block/blue_candle");
        }
    }
}
