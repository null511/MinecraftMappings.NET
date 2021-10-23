using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SmithingTableBottom : JavaBlockTexture
    {
        public SmithingTableBottom() : base("Smithing Table Bottom")
        {
            AddVersion("smithing_table_bottom")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.SmithingTable>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.SmithingTableBottom>();
        }
    }
}
