using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlackCandle : JavaBlockData
    {
        public BlackCandle() : base("Black Candle")
        {
            AddVersion("black_candle")
                .WithDefaultModel<Java.Models.Block.BlackCandle_OneCandle>();
                //.MapsToBedrockBlock<BedrockBlocks.BlackCandle>();
        }
    }
}
