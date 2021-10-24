using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class LoomBottom : BedrockBlockTexture
    {
        public LoomBottom() : base("Loom Bottom")
        {
            AddVersion("loom_bottom")
                .MapsToJavaBlock<Java.Textures.Block.LoomBottom>();
        }
    }
}
