using MinecraftMappings.Internal.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Candle : JavaBlockData
    {
        public Candle() : base("Candle")
        {
            AddVersion("candle")
                .WithDefaultModel<Java.Models.Block.Candle_OneCandle>();
                //.MapsToBedrockBlock<BedrockBlocks.Candle>();
        }
    }
}
