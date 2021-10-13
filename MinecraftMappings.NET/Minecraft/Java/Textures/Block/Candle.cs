using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Candle : JavaBlockTexture
    {
        public Candle() : base("Candle")
        {
            AddVersion("candle")
                .WithDefaultModel<Java.Models.Block.Candle_OneCandle>();
                //.MapsToBedrockBlock<BedrockBlocks.Candle>();
        }
    }
}
