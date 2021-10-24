using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class CartographyTable_Side1 : BedrockBlockTexture
    {
        public CartographyTable_Side1() : base("Cartography Table, Side 1")
        {
            AddVersion("cartography_table_side1")
                .MapsToJavaBlock<Java.Textures.Block.CartographyTable_Side1>();
        }
    }
}
