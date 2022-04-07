using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate
{
    public class PolishedDeepslate : BedrockBlockTexture
    {
        public PolishedDeepslate() : base("Polished Deepslate")
        {
            AddVersion("polished_deepslate")
                .MapsToJavaBlock<Java.Textures.Block.PolishedDeepslate>();
        }
    }
}
