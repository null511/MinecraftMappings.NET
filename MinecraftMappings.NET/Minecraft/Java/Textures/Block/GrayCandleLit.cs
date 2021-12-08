using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GrayCandleLit : JavaBlockTexture
    {
        public GrayCandleLit() : base("Gray Candle, Lit")
        {
            AddVersion("gray_candle_lit");
                //.WithDefaultModel<Java.Models.Block.GrayCandle_OneCandle_Lit>()
                //.MapsToBedrockBlock<BedrockBlocks.GrayCandleLit>();
        }
    }
}
