using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedCandleLit : JavaBlockTexture
    {
        public RedCandleLit() : base("Red Candle, Lit")
        {
            AddVersion("red_candle_lit");
                //.WithDefaultModel<Java.Models.Block.RedCandle_OneCandle_Lit>()
                //.MapsToBedrockBlock<BedrockBlocks.RedCandleLit>();
        }
    }
}
