using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class LogOakTop : BedrockBlockTexture
    {
        public LogOakTop() : base("Log Oak, Top")
        {
            AddVersion("log_oak_top")
                .MapsToJavaBlock<Java.Textures.Block.OakLogTop>();
        }
    }
}
