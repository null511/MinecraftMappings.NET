using MinecraftMappings.Internal.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CandleLit : JavaBlockData
    {
        public CandleLit() : base("Candle, Lit")
        {
            AddVersion("candle_lit")
                .WithDefaultModel<Java.Models.Block.Candle_OneCandle_Lit>();
                //.MapsToBedrockBlock<BedrockBlocks.CandleLit>();
        }
    }
}
