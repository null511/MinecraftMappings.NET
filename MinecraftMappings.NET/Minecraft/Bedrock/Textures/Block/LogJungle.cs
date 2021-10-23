using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class LogJungle : BedrockBlockTexture
    {
        public LogJungle() : base("Log Jungle")
        {
            AddVersion("log_jungle")
                .MapsToJavaBlock<Java.Textures.Block.JungleLog>();
        }
    }
}
