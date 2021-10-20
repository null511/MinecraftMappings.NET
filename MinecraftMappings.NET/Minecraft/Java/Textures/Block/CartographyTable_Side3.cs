using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CartographyTable_Side3 : JavaBlockTexture
    {
        public CartographyTable_Side3() : base("Cartography Table, Side 3")
        {
            AddVersion("cartography_table_side3")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.CartographyTable>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.StoneCalcite>();
        }
    }
}
