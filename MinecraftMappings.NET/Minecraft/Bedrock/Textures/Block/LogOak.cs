using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class LogOak : BedrockBlockTexture
    {
        public LogOak() : base("Log Oak")
        {
            AddVersion("log_oak")
                .MapsToJavaBlock<Java.Textures.Block.OakLog>();
        }
    }
}
