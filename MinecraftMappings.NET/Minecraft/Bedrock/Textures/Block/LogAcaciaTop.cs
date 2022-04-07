using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class LogAcaciaTop : BedrockBlockTexture
    {
        public LogAcaciaTop() : base("Log Acacia, Top")
        {
            AddVersion("log_acacia_top")
                .MapsToJavaBlock<Java.Textures.Block.AcaciaLogTop>();
        }
    }
}
