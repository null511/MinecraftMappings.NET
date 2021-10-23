using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SmithingTableSide : JavaBlockTexture
    {
        public SmithingTableSide() : base("Smithing Table Side")
        {
            AddVersion("smithing_table_side")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.SmithingTable>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.SmithingTableSide>();
        }
    }
}
