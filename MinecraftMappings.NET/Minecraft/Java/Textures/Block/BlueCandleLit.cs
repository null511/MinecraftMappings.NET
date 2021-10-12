using MinecraftMappings.Internal.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlueCandleLit : JavaBlockData
    {
        public BlueCandleLit() : base("Blue Candle, Lit")
        {
            AddVersion("blue_candle_lit")
                .WithDefaultModel<Java.Models.Block.BlueCandle_OneCandle_Lit>();
                //.MapsToBedrockBlock<BedrockBlocks.BlueCandleLit>();
        }
    }
}
