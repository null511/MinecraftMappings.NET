using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LightGrayCandle : JavaBlockTexture
    {
        public LightGrayCandle() : base("Light Gray Candle")
        {
            AddVersion("light_gray_candle");
                //.WithDefaultModel<Java.Models.Block.LightGrayCandle_OneCandle>()
                //.MapsToBedrockBlock<BedrockBlocks.LightGrayCandle>();
        }
    }
}
