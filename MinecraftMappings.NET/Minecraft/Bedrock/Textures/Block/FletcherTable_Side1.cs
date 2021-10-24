using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class FletcherTable_Side1 : BedrockBlockTexture
    {
        public FletcherTable_Side1() : base("Fletcher Table, Side 1")
        {
            AddVersion("fletcher_table_side1")
                .MapsToJavaBlock<Java.Textures.Block.FletchingTable_Side>();
        }
    }
}
