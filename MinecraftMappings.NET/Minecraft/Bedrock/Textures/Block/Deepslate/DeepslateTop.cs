using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate
{
    public class DeepslateTop : BedrockBlockTexture
    {
        public DeepslateTop() : base("Deepslate Top")
        {
            AddVersion("deepslate_top")
                .MapsToJavaBlock<Java.Textures.Block.DeepslateTop>();
        }
    }
}
