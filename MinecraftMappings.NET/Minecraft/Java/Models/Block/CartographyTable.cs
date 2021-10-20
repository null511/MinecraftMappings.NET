using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CartographyTable : JavaBlockModel
    {
        public CartographyTable() : base("Cartography Table")
        {
            AddVersion("cartography_table", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube")
                .AddTexture("up", "block/cartography_table_top")
                .AddTexture("down", "block/dark_oak_planks")
                .AddTexture("north", "block/cartography_table_side3")
                .AddTexture("south", "block/cartography_table_side1")
                .AddTexture("east", "block/cartography_table_side3")
                .AddTexture("west", "block/cartography_table_side2");
        }
    }
}
