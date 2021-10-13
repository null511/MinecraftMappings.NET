using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CraftingTableSide : JavaBlockTexture
    {
        public CraftingTableSide() : base("Crafting Table, Side")
        {
            AddVersion("crafting_table_side")
                .WithDefaultModel<Java.Models.Block.CraftingTable>();
                //.MapsToBedrockBlock<BedrockBlocks.CraftingTableSide>();
        }
    }
}
