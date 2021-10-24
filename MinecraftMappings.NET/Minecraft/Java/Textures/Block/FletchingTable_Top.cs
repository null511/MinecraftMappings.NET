using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class FletchingTable_Top : JavaBlockTexture
    {
        public FletchingTable_Top() : base("Fletching Table, Top")
        {
            AddVersion("fletching_table_top")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.FletchingTable>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FletcherTable_Top>();
        }
    }
}
