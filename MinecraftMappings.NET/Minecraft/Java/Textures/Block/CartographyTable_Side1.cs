using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CartographyTable_Side1 : JavaBlockTexture
    {
        public CartographyTable_Side1() : base("Cartography Table, Side 1")
        {
            AddVersion("cartography_table_side1")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.CartographyTable>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.StoneCalcite>();
        }
    }
}
