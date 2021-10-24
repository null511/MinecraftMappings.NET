using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class EnchantingTableSide : BedrockBlockTexture
    {
        public EnchantingTableSide() : base("Enchanting Table Side")
        {
            AddVersion("enchanting_table_side")
                .MapsToJavaBlock<Java.Textures.Block.EnchantingTableSide>();
        }
    }
}
