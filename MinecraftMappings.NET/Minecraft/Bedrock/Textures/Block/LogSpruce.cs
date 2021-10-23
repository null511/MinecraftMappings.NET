using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class LogSpruce : BedrockBlockTexture
    {
        public LogSpruce() : base("Log Spruce")
        {
            AddVersion("log_spruce")
                .MapsToJavaBlock<Java.Textures.Block.SpruceLog>();
        }
    }
}
