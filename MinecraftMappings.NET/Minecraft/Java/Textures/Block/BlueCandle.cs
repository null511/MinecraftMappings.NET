using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlueCandle : JavaBlockTexture
    {
        public BlueCandle() : base("Blue Candle")
        {
            AddVersion("blue_candle")
                .WithDefaultModel<Java.Models.Block.BlueCandle_OneCandle>();
                //.MapsToBedrockBlock<BedrockBlocks.BlueCandle>();
        }
    }
}
