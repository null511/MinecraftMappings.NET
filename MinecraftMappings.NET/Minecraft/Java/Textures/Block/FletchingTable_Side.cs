using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class FletchingTable_Side : JavaBlockTexture
    {
        public FletchingTable_Side() : base("Fletching Table, Side")
        {
            AddVersion("fletching_table_side")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.FletchingTable>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FletchingTable_Side>();
        }
    }
}
