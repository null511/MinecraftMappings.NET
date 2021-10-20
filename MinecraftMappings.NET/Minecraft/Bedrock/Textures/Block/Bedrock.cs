using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class Bedrock : BedrockBlockTexture
    {
        public Bedrock() : base("Bedrock")
        {
            AddVersion("bedrock")
                .MapsToJavaBlock<Java.Textures.Block.Bedrock>();
        }
    }
}
