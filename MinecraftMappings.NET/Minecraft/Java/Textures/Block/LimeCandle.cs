using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LimeCandle : JavaBlockTexture
    {
        public LimeCandle() : base("Lime Candle")
        {
            AddVersion("lime_candle");
                //.WithDefaultModel<Java.Models.Block.LimeCandle_OneCandle>()
                //.MapsToBedrockBlock<BedrockBlocks.LimeCandle>();
        }
    }
}
