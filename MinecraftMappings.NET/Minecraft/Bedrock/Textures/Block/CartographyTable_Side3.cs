using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class CartographyTable_Side3 : BedrockBlockTexture
    {
        public CartographyTable_Side3() : base("Cartography Table, Side 3")
        {
            AddVersion("cartography_table_side3")
                .MapsToJavaBlock<Java.Textures.Block.CartographyTable_Side3>();
        }
    }
}
