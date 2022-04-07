using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate
{
    public class Deepslate : BedrockBlockTexture
    {
        public Deepslate() : base("Deepslate")
        {
            AddVersion("deepslate")
                .MapsToJavaBlock<Java.Textures.Block.Deepslate>();
        }
    }
}
