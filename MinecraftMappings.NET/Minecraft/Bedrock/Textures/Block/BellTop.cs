using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class BellTop : BedrockBlockTexture
    {
        public BellTop() : base("Bell Top")
        {
            AddVersion("bell_top")
                .MapsToJavaBlock<Java.Textures.Block.BellTop>();
        }
    }
}
