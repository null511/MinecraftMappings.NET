using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class LogBirch : BedrockBlockTexture
    {
        public LogBirch() : base("Log Birch")
        {
            AddVersion("log_birch")
                .MapsToJavaBlock<BirchLog>();
        }
    }
}
