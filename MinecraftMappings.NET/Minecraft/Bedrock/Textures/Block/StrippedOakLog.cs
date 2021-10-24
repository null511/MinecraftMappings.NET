using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class StrippedOakLog : BedrockBlockTexture
    {
        public StrippedOakLog() : base("Stripped Oak Log")
        {
            AddVersion("stripped_oak_log")
                .MapsToJavaBlock<Java.Textures.Block.StrippedOakLog>();
        }
    }
}
