using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class NetherSprouts : BedrockBlockTexture
    {
        public NetherSprouts() : base("Nether Sprouts")
        {
            AddVersion("nether_sprouts")
                .MapsToJavaBlock<Java.Textures.Block.NetherSprouts>();
        }
    }
}
