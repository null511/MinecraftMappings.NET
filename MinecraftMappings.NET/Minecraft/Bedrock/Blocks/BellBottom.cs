using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BellBottom : BedrockBlockTexture
    {
        public BellBottom() : base("Bell Bottom")
        {
            AddVersion("bell_bottom")
                .MapsToJavaBlock<Java.Textures.Block.BellBottom>();
        }
    }
}
