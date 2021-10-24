using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class LoomFront : BedrockBlockTexture
    {
        public LoomFront() : base("Loom Front")
        {
            AddVersion("loom_front")
                .MapsToJavaBlock<Java.Textures.Block.LoomFront>();
        }
    }
}
