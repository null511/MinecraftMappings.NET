using MinecraftMappings.Internal.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlueCandle : JavaBlockData
    {
        public BlueCandle() : base("Blue Candle")
        {
            AddVersion("blue_candle")
                .WithDefaultModel<Java.Models.Block.BlueCandle_OneCandle>();
                //.MapsToBedrockBlock<BedrockBlocks.BlueCandle>();
        }
    }
}
