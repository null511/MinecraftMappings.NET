using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class SmithingTable : JavaBlockModel
    {
        public SmithingTable() : base("Smithing Table")
        {
            AddVersion("smithing_table", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube")
                .AddTexture("up", "block/smithing_table_top")
                .AddTexture("down", "block/smithing_table_bottom")
                .AddTexture("north", "block/smithing_table_front")
                .AddTexture("south", "block/smithing_table_front")
                .AddTexture("west", "block/smithing_table_side")
                .AddTexture("east", "block/smithing_table_side");
        }
    }
}
