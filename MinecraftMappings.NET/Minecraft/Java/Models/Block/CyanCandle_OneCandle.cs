using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CyanCandle_OneCandle : JavaBlockModel
    {
        public CyanCandle_OneCandle() : base("Cyan Candle, One Candle")
        {
            AddVersion("cyan_candle_one_candle", "1.17")
                .WithPath("models/block")
                .WithParent("block/template_candle")
                .AddTexture("all", "block/cyan_candle");
        }
    }
}
