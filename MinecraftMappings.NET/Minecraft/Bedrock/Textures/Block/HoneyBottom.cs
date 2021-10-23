using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class HoneyBottom : BedrockBlockTexture
    {
        public HoneyBottom() : base("Honey Bottom")
        {
            AddVersion("honey_bottom")
                .MapsToJavaBlock<Java.Textures.Block.HoneyBlockBottom>();
        }
    }
}
