using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SmithingTableTop : JavaBlockTexture
    {
        public SmithingTableTop() : base("Smithing Table Top")
        {
            AddVersion("smithing_table_top")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.SmithingTable>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.SmithingTableTop>();
        }
    }
}
