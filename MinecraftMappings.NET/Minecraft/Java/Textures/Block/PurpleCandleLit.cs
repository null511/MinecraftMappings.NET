using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PurpleCandleLit : JavaBlockTexture
    {
        public PurpleCandleLit() : base("Purple Candle, Lit")
        {
            AddVersion("purple_candle_lit");
                //.WithDefaultModel<Java.Models.Block.PurpleCandle_OneCandle_Lit>()
                //.MapsToBedrockBlock<BedrockBlocks.PurpleCandleLit>();
        }
    }
}
