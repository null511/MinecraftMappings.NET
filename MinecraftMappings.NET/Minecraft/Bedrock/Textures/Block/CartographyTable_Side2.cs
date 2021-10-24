using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class CartographyTable_Side2 : BedrockBlockTexture
    {
        public CartographyTable_Side2() : base("Cartography Table, Side 2")
        {
            AddVersion("cartography_table_side2")
                .MapsToJavaBlock<Java.Textures.Block.CartographyTable_Side2>();
        }
    }
}
