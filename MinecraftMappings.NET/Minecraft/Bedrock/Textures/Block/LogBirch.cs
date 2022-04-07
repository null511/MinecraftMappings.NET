using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class LogBirch : BedrockBlockTexture
    {
        public LogBirch() : base("Log Birch")
        {
            AddVersion("log_birch")
                .MapsToJavaBlock<Java.Textures.Block.BirchLog>();
        }
    }
}
