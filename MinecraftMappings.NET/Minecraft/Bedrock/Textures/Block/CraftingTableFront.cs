using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class CraftingTableFront : BedrockBlockTexture
    {
        public CraftingTableFront() : base("Crafting Table Front")
        {
            AddVersion("crafting_table_front")
                .MapsToJavaBlock<Java.Textures.Block.CraftingTableFront>();
        }
    }
}
