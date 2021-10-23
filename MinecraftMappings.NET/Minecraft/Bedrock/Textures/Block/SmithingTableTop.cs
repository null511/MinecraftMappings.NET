using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class SmithingTableTop : BedrockBlockTexture
    {
        public SmithingTableTop() : base("Smithing Table Top")
        {
            AddVersion("smithing_table_top")
                .MapsToJavaBlock<Java.Textures.Block.SmithingTableTop>();
        }
    }
}
