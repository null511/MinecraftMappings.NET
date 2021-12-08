using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class YellowCandleLit : JavaBlockTexture
    {
        public YellowCandleLit() : base("Yellow Candle Lit")
        {
            AddVersion("yellow_candle_Lit");
                //.WithDefaultModel<Java.Models.Block.YellowCandle_OneCandle_Lit>()
                //.MapsToBedrockBlock<BedrockBlocks.YellowCandleLit>();
        }
    }
}
