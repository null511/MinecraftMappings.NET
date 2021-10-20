using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CraftingTable : JavaBlockModel
    {
        public CraftingTable() : base("Crafting Table")
        {
            AddVersion("crafting_table", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube")
                .AddTexture("up", "block/crafting_table_top")
                .AddTexture("down", "block/oak_planks")
                .AddTexture("north", "block/crafting_table_front")
                .AddTexture("south", "block/crafting_table_side")
                .AddTexture("west", "block/crafting_table_front")
                .AddTexture("east", "block/crafting_table_side");
        }
    }
}
