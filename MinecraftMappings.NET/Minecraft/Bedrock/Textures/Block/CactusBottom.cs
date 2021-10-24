using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class CactusBottom : BedrockBlockTexture
    {
        public CactusBottom() : base("Cactus Bottom")
        {
            AddVersion("cactus_bottom")
                .MapsToJavaBlock<Java.Textures.Block.CactusBottom>();
        }
    }
}
