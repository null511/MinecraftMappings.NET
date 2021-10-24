using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class EnchantingTableTop : JavaBlockTexture
    {
        public EnchantingTableTop() : base("Enchanting Table Top")
        {
            AddVersion("enchanting_table_top")
                .WithDefaultModel<Java.Models.Block.EnchantingTable>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.EnchantingTableTop>();
        }
    }
}
