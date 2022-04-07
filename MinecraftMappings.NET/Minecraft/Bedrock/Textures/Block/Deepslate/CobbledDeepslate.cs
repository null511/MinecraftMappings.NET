using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate
{
    public class CobbledDeepslate : BedrockBlockTexture
    {
        public CobbledDeepslate() : base("Cobbled Deepslate")
        {
            AddVersion("cobbled_deepslate")
                .MapsToJavaBlock<Java.Textures.Block.CobbledDeepslate>();
        }
    }
}
