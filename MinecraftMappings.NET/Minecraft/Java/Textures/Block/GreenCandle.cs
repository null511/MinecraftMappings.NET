using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GreenCandle : JavaBlockTexture
    {
        public GreenCandle() : base("Green Candle")
        {
            AddVersion("green_candle");
                //.WithDefaultModel<Java.Models.Block.GreenCandle_OneCandle>()
                //.MapsToBedrockBlock<BedrockBlocks.GreenCandle>();
        }
    }
}
