using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PinkCandleLit : JavaBlockTexture
    {
        public PinkCandleLit() : base("Pink Candle, Lit")
        {
            AddVersion("pink_candle_lit");
                //.WithDefaultModel<Java.Models.Block.PinkCandle_OneCandle_Lit>()
                //.MapsToBedrockBlock<BedrockBlocks.PinkCandleLit>();
        }
    }
}
