using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class EnchantingTableTop : BedrockBlockTexture
    {
        public EnchantingTableTop() : base("Enchanting Table Top")
        {
            AddVersion("enchanting_table_top")
                .MapsToJavaBlock<Java.Textures.Block.EnchantingTableTop>();
        }
    }
}
