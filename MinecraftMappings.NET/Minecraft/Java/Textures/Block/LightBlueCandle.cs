using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LightBlueCandle : JavaBlockTexture
    {
        public LightBlueCandle() : base("Light Blue Candle")
        {
            AddVersion("light_blue_candle");
                //.WithDefaultModel<Java.Models.Block.LightBlueCandle_OneCandle>()
                //.MapsToBedrockBlock<BedrockBlocks.LightBlueCandle>();
        }
    }
}
