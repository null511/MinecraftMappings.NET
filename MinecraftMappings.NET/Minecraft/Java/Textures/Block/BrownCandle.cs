using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrownCandle : JavaBlockTexture
    {
        public BrownCandle() : base("Brown Candle")
        {
            AddVersion("brown_candle")
                .WithDefaultModel<Java.Models.Block.BrownCandle_OneCandle>();
                //.MapsToBedrockBlock<BedrockBlocks.BrownCandle>();
        }
    }
}
