using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class CauldronTop : BedrockBlockTexture
    {
        public CauldronTop() : base("Cauldron Top")
        {
            AddVersion("cauldron_top")
                .MapsToJavaBlock<Java.Textures.Block.CauldronTop>();
        }
    }
}
