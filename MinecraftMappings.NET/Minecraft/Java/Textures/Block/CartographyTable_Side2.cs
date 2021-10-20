using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CartographyTable_Side2 : JavaBlockTexture
    {
        public CartographyTable_Side2() : base("Cartography Table, Side 2")
        {
            AddVersion("cartography_table_side2")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.CartographyTable>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.StoneCalcite>();
        }
    }
}
