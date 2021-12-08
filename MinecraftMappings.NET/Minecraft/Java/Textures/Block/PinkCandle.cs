using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PinkCandle : JavaBlockTexture
    {
        public PinkCandle() : base("Pink Candle")
        {
            AddVersion("pink_candle");
                //.WithDefaultModel<Java.Models.Block.PinkCandle_OneCandle>()
                //.MapsToBedrockBlock<BedrockBlocks.PinkCandle>();
        }
    }
}
