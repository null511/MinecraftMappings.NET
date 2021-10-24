using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class CraftingTableSide : BedrockBlockTexture
    {
        public CraftingTableSide() : base("Crafting Table Side")
        {
            AddVersion("crafting_table_side")
                .MapsToJavaBlock<Java.Textures.Block.CraftingTableSide>();
        }
    }
}
