using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class FletcherTable_Top : BedrockBlockTexture
    {
        public FletcherTable_Top() : base("Fletcher Table, Top")
        {
            AddVersion("fletcher_table_top")
                .MapsToJavaBlock<Java.Textures.Block.FletchingTable_Top>();
        }
    }
}
