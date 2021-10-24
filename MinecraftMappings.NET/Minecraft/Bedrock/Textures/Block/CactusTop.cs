using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class CactusTop : BedrockBlockTexture
    {
        public CactusTop() : base("Cactus Top")
        {
            AddVersion("cactus_top")
                .MapsToJavaBlock<Java.Textures.Block.CactusTop>();
        }
    }
}
