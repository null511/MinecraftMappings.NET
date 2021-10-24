using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class CraftingTableTop : BedrockBlockTexture
    {
        public CraftingTableTop() : base("Crafting Table Top")
        {
            AddVersion("crafting_table_top")
                .MapsToJavaBlock<Java.Textures.Block.CraftingTableTop>();
        }
    }
}
