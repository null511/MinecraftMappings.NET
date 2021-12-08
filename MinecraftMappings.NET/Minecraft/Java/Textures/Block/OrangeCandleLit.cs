using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OrangeCandleLit : JavaBlockTexture
    {
        public OrangeCandleLit() : base("Orange Candle, Lit")
        {
            AddVersion("orange_candle_lit");
                //.WithDefaultModel<Java.Models.Block.OrangeCandle_OneCandle_Lit>()
                //.MapsToBedrockBlock<BedrockBlocks.OrangeCandleLit>();
        }
    }
}
