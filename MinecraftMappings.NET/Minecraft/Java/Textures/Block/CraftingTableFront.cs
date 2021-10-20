using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CraftingTableFront : JavaBlockTexture
    {
        public CraftingTableFront() : base("Crafting Table, Front")
        {
            AddVersion("crafting_table_front")
                .WithDefaultModel<Java.Models.Block.CraftingTable>();
                //.MapsToBedrockBlock<BedrockBlocks.CraftingTableFront>();
        }
    }
}
