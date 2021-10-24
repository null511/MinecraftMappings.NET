using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class CartographyTable_Top : BedrockBlockTexture
    {
        public CartographyTable_Top() : base("Cartography Table, Top")
        {
            AddVersion("cartography_table_top")
                .MapsToJavaBlock<Java.Textures.Block.CartographyTable_Top>();
        }
    }
}
