using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class SmithingTableBottom : BedrockBlockTexture
    {
        public SmithingTableBottom() : base("Smithing Table Bottom")
        {
            AddVersion("smithing_table_bottom")
                .MapsToJavaBlock<Java.Textures.Block.SmithingTableBottom>();
        }
    }
}
