using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class EnchantingTableBottom : JavaBlockTexture
    {
        public EnchantingTableBottom() : base("Enchanting Table Bottom")
        {
            AddVersion("enchanting_table_bottom")
                .WithDefaultModel<Java.Models.Block.EnchantingTable>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.EnchantingTableBottom>();
        }
    }
}
