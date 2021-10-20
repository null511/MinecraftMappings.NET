using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlueCandle_OneCandle_Lit : JavaBlockModel
    {
        public BlueCandle_OneCandle_Lit() : base("Blue Candle, One Candle, Lit")
        {
            AddVersion("blue_candle_one_candle_lit", "1.17")
                .WithPath("models/block")
                .WithParent("block/template_candle")
                .AddTexture("all", "block/blue_candle_lit");
        }
    }
}
