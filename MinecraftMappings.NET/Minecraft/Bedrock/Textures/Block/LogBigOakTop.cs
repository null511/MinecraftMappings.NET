using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class LogBigOakTop : BedrockBlockTexture
    {
        public LogBigOakTop() : base("Log Big Oak Top")
        {
            AddVersion("log_big_oak_top")
                .MapsToJavaBlock<Java.Textures.Block.DarkOakLogTop>();
        }
    }
}
