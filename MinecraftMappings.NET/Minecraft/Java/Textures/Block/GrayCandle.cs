using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GrayCandle : JavaBlockTexture
    {
        public GrayCandle() : base("Gray Candle")
        {
            AddVersion("gray_candle");
                //.WithDefaultModel<Java.Models.Block.GrayCandle_OneCandle>()
                //.MapsToBedrockBlock<BedrockBlocks.GrayCandle>();
        }
    }
}
