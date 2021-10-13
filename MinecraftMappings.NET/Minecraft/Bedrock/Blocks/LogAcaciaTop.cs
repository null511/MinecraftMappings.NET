using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class LogAcaciaTop : BedrockBlockTexture
    {
        public LogAcaciaTop() : base("Log Acacia, Top")
        {
            AddVersion("log_acacia_top")
                .MapsToJavaBlock<AcaciaLogTop>();
        }
    }
}
