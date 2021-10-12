using MinecraftMappings.Internal.Blocks;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class Bedrock : BedrockBlockData
    {
        public Bedrock() : base("Bedrock")
        {
            AddVersion("bedrock")
                .MapsToJavaBlock<Java.Textures.Block.Bedrock>();
        }
    }
}
