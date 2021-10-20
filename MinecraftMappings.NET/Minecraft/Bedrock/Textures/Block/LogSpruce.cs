using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class LogSpruce : BedrockBlockTexture
    {
        public LogSpruce() : base("Log Spruce")
        {
            AddVersion("log_spruce")
                .MapsToJavaBlock<SpruceLog>();
        }
    }
}
