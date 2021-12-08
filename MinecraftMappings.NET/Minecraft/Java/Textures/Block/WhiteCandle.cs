using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WhiteCandle : JavaBlockTexture
    {
        public WhiteCandle() : base("White Candle")
        {
            AddVersion("white_candle");
                //.WithDefaultModel<Java.Models.Block.WhiteCandle_OneCandle>()
                //.MapsToBedrockBlock<BedrockBlocks.WhiteCandle>();
        }
    }
}
