using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Candle_OneCandle : JavaBlockModel
    {
        public Candle_OneCandle() : base("Candle, One Candle")
        {
            AddVersion("candle_one_candle", "1.17")
                .WithPath("models/block")
                .WithParent("block/template_candle")
                .AddTexture("all", "block/candle");
        }
    }
}
