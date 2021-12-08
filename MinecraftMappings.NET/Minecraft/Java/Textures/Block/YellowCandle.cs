using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class YellowCandle : JavaBlockTexture
    {
        public YellowCandle() : base("Yellow Candle")
        {
            AddVersion("yellow_candle");
                //.WithDefaultModel<Java.Models.Block.YellowCandle_OneCandle>()
                //.MapsToBedrockBlock<BedrockBlocks.YellowCandle>();
        }
    }
}
