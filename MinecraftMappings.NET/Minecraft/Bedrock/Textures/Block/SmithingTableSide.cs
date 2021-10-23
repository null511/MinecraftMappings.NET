using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class SmithingTableSide : BedrockBlockTexture
    {
        public SmithingTableSide() : base("Smithing Table Side")
        {
            AddVersion("smithing_table_side")
                .MapsToJavaBlock<Java.Textures.Block.SmithingTableSide>();
        }
    }
}
