using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class LogJungleTop : BedrockBlockTexture
    {
        public LogJungleTop() : base("Log Jungle Top")
        {
            AddVersion("log_jungle_top")
                .MapsToJavaBlock<Java.Textures.Block.JungleLogTop>();
        }
    }
}
