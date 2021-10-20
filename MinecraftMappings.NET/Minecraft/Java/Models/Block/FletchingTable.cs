using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class FletchingTable : JavaBlockModel
    {
        public FletchingTable() : base("Fletching Table")
        {
            AddVersion("fletching_table", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube")
                .AddTexture("up", "block/fletching_table_top")
                .AddTexture("down", "block/birch_planks")
                .AddTexture("north", "block/fletching_table_front")
                .AddTexture("south", "block/fletching_table_front")
                .AddTexture("west", "block/fletching_table_side")
                .AddTexture("east", "block/fletching_table_side");
        }
    }
}
