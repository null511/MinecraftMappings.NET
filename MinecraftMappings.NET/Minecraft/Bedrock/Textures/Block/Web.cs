using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class Web : BedrockBlockTexture
    {
        public Web() : base("Web")
        {
            AddVersion("web")
                .MapsToJavaBlock<Java.Textures.Block.Cobweb>();
        }
    }
}
