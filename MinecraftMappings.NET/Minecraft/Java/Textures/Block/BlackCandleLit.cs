using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlackCandleLit : JavaBlockTexture
    {
        public BlackCandleLit() : base("Black Candle, Lit")
        {
            AddVersion("black_candle_lit")
                .WithDefaultModel<Java.Models.Block.BlackCandle_OneCandle_Lit>();
                //.MapsToBedrockBlock<BedrockBlocks.BlackCandleLit>();
        }
    }
}
