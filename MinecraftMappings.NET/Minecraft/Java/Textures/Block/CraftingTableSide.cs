using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CraftingTableSide : JavaBlockTexture
    {
        public CraftingTableSide() : base("Crafting Table, Side")
        {
            AddVersion("crafting_table_side")
                .WithDefaultModel<Java.Models.Block.CraftingTable>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CraftingTableSide>();
        }
    }
}
