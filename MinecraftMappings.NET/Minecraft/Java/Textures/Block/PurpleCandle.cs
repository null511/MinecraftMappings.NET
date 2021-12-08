using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PurpleCandle : JavaBlockTexture
    {
        public PurpleCandle() : base("Purple Candle")
        {
            AddVersion("purple_candle");
                //.WithDefaultModel<Java.Models.Block.PurpleCandle_OneCandle>()
                //.MapsToBedrockBlock<BedrockBlocks.PurpleCandle>();
        }
    }
}
