using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class CrimsonLogTop : BedrockBlockTexture
    {
        public CrimsonLogTop() : base("Crimson Log Top")
        {
            AddVersion("crimson_log_top")
                .MapsToJavaBlock<Java.Textures.Block.CrimsonStemTop>();
        }
    }
}
