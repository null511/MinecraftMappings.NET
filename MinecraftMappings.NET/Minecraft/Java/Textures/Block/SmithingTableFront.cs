using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SmithingTableFront : JavaBlockTexture
    {
        public SmithingTableFront() : base("Smithing Table Front")
        {
            AddVersion("smithing_table_front")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.SmithingTable>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.SmithingTableFront>();
        }
    }
}
