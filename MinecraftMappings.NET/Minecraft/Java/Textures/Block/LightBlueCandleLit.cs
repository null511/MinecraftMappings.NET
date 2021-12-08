using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LightBlueCandleLit : JavaBlockTexture
    {
        public LightBlueCandleLit() : base("Light Blue Candle, Lit")
        {
            AddVersion("light_blue_candle_lit");
                //.WithDefaultModel<Java.Models.Block.LightBlueCandle_OneCandle_Lit>()
                //.MapsToBedrockBlock<BedrockBlocks.LightBlueCandleLit>();
        }
    }
}
