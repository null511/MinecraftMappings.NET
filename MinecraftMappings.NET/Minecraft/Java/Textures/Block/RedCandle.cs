using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedCandle : JavaBlockTexture
    {
        public RedCandle() : base("Red Candle")
        {
            AddVersion("red_candle");
                //.WithDefaultModel<Java.Models.Block.RedCandle_OneCandle>()
                //.MapsToBedrockBlock<BedrockBlocks.RedCandle>();
        }
    }
}
