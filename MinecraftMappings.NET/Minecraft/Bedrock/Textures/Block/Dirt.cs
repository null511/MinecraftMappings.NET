using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class Dirt : BedrockBlockTexture
    {
        public Dirt() : base("Dirt")
        {
            AddVersion("dirt")
                .MapsToJavaBlock<Java.Textures.Block.Dirt>();
        }
    }
}
