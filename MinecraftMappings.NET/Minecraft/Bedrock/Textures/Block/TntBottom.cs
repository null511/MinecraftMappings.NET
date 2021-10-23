using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class TntBottom : BedrockBlockTexture
    {
        public TntBottom() : base("TNT Bottom")
        {
            AddVersion("tnt_bottom")
                .MapsToJavaBlock<Java.Textures.Block.TntBottom>();
        }
    }
}
