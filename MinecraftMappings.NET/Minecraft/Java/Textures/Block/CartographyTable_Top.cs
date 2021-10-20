using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CartographyTable_Top : JavaBlockTexture
    {
        public CartographyTable_Top() : base("Cartography Table, Top")
        {
            AddVersion("cartography_table_top")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.CartographyTable>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.StoneCalcite>();
        }
    }
}
