using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class ObserverBackLit : BedrockBlockTexture
    {
        public ObserverBackLit() : base("Observer Back, Lit")
        {
            AddVersion("observer_back_lit")
                .MapsToJavaBlock<Java.Textures.Block.ObserverBackLit>();
        }
    }
}
