using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CyanCandle : JavaBlockTexture
    {
        public CyanCandle() : base("Cyan Candle")
        {
            AddVersion("cyan_candle")
                .WithDefaultModel<Java.Models.Block.CyanCandle_OneCandle>();
                //.MapsToBedrockBlock<BedrockBlocks.CyanCandle>();
        }
    }
}
