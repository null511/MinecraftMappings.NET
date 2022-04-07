using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class LogBigOak : BedrockBlockTexture
    {
        public LogBigOak() : base("Log Big Oak")
        {
            AddVersion("log_big_oak")
                .MapsToJavaBlock<Java.Textures.Block.DarkOakLog>();
        }
    }
}
