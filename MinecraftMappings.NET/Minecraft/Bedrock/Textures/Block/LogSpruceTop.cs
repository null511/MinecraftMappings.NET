using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class LogSpruceTop : BedrockBlockTexture
    {
        public LogSpruceTop() : base("Log Spruce, Top")
        {
            AddVersion("log_spruce_top")
                .MapsToJavaBlock<SpruceLogTop>();
        }
    }
}
