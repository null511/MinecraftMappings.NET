using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class EnchantingTableBottom : BedrockBlockTexture
    {
        public EnchantingTableBottom() : base("Enchanting Table Bottom")
        {
            AddVersion("enchanting_table_bottom")
                .MapsToJavaBlock<Java.Textures.Block.EnchantingTableBottom>();
        }
    }
}
