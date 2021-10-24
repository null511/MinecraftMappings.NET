using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class CauldronBottom : BedrockBlockTexture
    {
        public CauldronBottom() : base("Cauldron Bottom")
        {
            AddVersion("cauldron_bottom")
                .MapsToJavaBlock<Java.Textures.Block.CauldronBottom>();
        }
    }
}
