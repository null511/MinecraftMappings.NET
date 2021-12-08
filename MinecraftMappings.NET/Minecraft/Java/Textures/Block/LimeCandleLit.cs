using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LimeCandleLit : JavaBlockTexture
    {
        public LimeCandleLit() : base("Lime Candle, Lit")
        {
            AddVersion("lime_candle_lit");
                //.WithDefaultModel<Java.Models.Block.LimeCandle_OneCandle_Lit>()
                //.MapsToBedrockBlock<BedrockBlocks.LimeCandleLit>();
        }
    }
}
