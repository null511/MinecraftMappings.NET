using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrownCandleLit : JavaBlockTexture
    {
        public BrownCandleLit() : base("Brown Candle, Lit")
        {
            AddVersion("brown_candle_lit")
                .WithDefaultModel<Java.Models.Block.BrownCandle_OneCandle_Lit>();
                //.MapsToBedrockBlock<BedrockBlocks.BrownCandleLit>();
        }
    }
}
