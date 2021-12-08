using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class MagentaCandle : JavaBlockTexture
    {
        public MagentaCandle() : base("Magenta Candle")
        {
            AddVersion("magenta_candle");
                //.WithDefaultModel<Java.Models.Block.MagentaCandle_OneCandle>()
                //.MapsToBedrockBlock<BedrockBlocks.MagentaCandle>();
        }
    }
}
