using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class SmithingTableFront : BedrockBlockTexture
    {
        public SmithingTableFront() : base("Smithing Table Front")
        {
            AddVersion("smithing_table_front")
                .MapsToJavaBlock<Java.Textures.Block.SmithingTableFront>();
        }
    }
}
