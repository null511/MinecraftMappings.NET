using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CyanCandleLit : JavaBlockTexture
    {
        public CyanCandleLit() : base("Cyan Candle, Lit")
        {
            AddVersion("cyan_candle_lit")
                .WithDefaultModel<Java.Models.Block.CyanCandle_OneCandleLit>();
                //.MapsToBedrockBlock<BedrockBlocks.CyanCandleLit>();
        }
    }
}
