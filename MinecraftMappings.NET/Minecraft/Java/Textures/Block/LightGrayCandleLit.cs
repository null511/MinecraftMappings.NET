using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LightGrayCandleLit : JavaBlockTexture
    {
        public LightGrayCandleLit() : base("Light Gray Candle, Lit")
        {
            AddVersion("light_gray_candle_lit");
                //.WithDefaultModel<Java.Models.Block.LightGrayCandle_OneCandleLit>()
                //.MapsToBedrockBlock<BedrockBlocks.LightGrayCandleLit>();
        }
    }
}
