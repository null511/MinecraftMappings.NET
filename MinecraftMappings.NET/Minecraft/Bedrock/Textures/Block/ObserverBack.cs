using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class ObserverBack : BedrockBlockTexture
    {
        public ObserverBack() : base("Observer Back")
        {
            AddVersion("observer_back")
                .MapsToJavaBlock<Java.Textures.Block.ObserverBack>();
        }
    }
}
