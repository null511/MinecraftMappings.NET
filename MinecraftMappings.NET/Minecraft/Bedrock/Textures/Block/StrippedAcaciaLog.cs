using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class StrippedAcaciaLog : BedrockBlockTexture
    {
        public StrippedAcaciaLog() : base("Stripped Acacia Log")
        {
            AddVersion("stripped_acacia_log")
                .MapsToJavaBlock<Java.Textures.Block.StrippedAcaciaLog>();
        }
    }
}
