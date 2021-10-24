using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class CauldronInner : BedrockBlockTexture
    {
        public CauldronInner() : base("Cauldron Inner")
        {
            AddVersion("cauldron_inner")
                .MapsToJavaBlock<Java.Textures.Block.CauldronInner>();
        }
    }
}
