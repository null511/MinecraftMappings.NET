using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class FletcherTable_Side2 : BedrockBlockTexture
    {
        public FletcherTable_Side2() : base("Fletcher Table, Side 2")
        {
            AddVersion("fletcher_table_side2")
                .MapsToJavaBlock<Java.Textures.Block.FletchingTable_Front>();
        }
    }
}
