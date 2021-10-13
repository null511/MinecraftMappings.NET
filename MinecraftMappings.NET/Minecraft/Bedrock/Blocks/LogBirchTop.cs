using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
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
