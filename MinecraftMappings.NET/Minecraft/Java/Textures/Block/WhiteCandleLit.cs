using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WhiteCandleLit : JavaBlockTexture
    {
        public WhiteCandleLit() : base("White Candle, Lit")
        {
            AddVersion("white_candle_lit");
                //.WithDefaultModel<Java.Models.Block.WhiteCandle_OneCandle_Lit>()
                //.MapsToBedrockBlock<BedrockBlocks.WhiteCandleLit>();
        }
    }
}
