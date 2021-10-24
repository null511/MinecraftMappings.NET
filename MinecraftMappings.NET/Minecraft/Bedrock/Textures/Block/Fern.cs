using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class Fern : BedrockBlockTexture
    {
        public Fern() : base("Fern")
        {
            AddVersion("fern")
                .MapsToJavaBlock<Java.Textures.Block.Fern>();
        }
    }
}
