using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlackCandle : JavaBlockTexture
    {
        public BlackCandle() : base("Black Candle")
        {
            AddVersion("black_candle")
                .WithDefaultModel<Java.Models.Block.BlackCandle_OneCandle>();
                //.MapsToBedrockBlock<BedrockBlocks.BlackCandle>();
        }
    }
}
