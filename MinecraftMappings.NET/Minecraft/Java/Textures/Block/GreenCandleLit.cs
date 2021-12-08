using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GreenCandleLit : JavaBlockTexture
    {
        public GreenCandleLit() : base("Green Candle, Lit")
        {
            AddVersion("green_candle_lit");
                //.WithDefaultModel<Java.Models.Block.GreenCandle_OneCandle_Lit>()
                //.MapsToBedrockBlock<BedrockBlocks.GreenCandleLit>();
        }
    }
}
