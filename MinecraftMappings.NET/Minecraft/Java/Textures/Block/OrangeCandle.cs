using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OrangeCandle : JavaBlockTexture
    {
        public OrangeCandle() : base("Orange Candle")
        {
            AddVersion("orange_candle");
                //.WithDefaultModel<Java.Models.Block.OrangeCandle_OneCandle>()
                //.MapsToBedrockBlock<BedrockBlocks.OrangeCandle>();
        }
    }
}
