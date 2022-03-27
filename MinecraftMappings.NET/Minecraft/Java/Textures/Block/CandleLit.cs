using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CandleLit : JavaBlockTexture
    {
        public CandleLit() : base("Candle, Lit")
        {
            AddVersion("candle_lit")
                .WithDefaultModel<Java.Models.Block.Candle_OneCandleLit>();
                //.MapsToBedrockBlock<BedrockBlocks.CandleLit>();
        }
    }
}
