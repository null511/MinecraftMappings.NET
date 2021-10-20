using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BrownCandle_OneCandle_Lit : JavaBlockModel
    {
        public BrownCandle_OneCandle_Lit() : base("Brown Candle, One Candle, Lit")
        {
            AddVersion("brown_candle_one_candle_lit", "1.17")
                .WithPath("models/block")
                .WithParent("block/template_candle")
                .AddTexture("all", "block/brown_candle_lit");
        }
    }
}
