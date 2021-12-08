using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class MagentaCandleLit : JavaBlockTexture
    {
        public MagentaCandleLit() : base("Magenta Candle, Lit")
        {
            AddVersion("magenta_candle_lit");
                //.WithDefaultModel<Java.Models.Block.MagentaCandle_OneCandle_Lit>()
                //.MapsToBedrockBlock<BedrockBlocks.MagentaCandleLit>();
        }
    }
}
