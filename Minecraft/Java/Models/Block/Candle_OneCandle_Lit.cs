using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Candle_OneCandle_Lit : JavaModelData
    {
        public Candle_OneCandle_Lit() : base("Candle, One Candle, Lit")
        {
            AddVersion("candle_one_candle_lit", "1.17")
                .WithPath("models/block")
                .WithParent("block/template_candle")
                .AddTexture("all", "block/candle_lit");
        }
    }
}
