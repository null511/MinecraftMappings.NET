using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class LogBirchTop : BedrockBlockTexture
    {
        public LogBirchTop() : base("Log Birch Top")
        {
            AddVersion("log_birch_top")
                .MapsToJavaBlock<BirchLogTop>();
        }
    }
}
