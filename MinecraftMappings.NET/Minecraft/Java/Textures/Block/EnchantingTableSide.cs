using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class EnchantingTableSide : JavaBlockTexture
    {
        public EnchantingTableSide() : base("Enchanting Table Side")
        {
            AddVersion("enchanting_table_side")
                .WithDefaultModel<Java.Models.Block.EnchantingTable>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.EnchantingTableSide>();
        }
    }
}
