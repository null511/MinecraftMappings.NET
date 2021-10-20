using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class BasaltTop : BedrockBlockTexture
    {
        public BasaltTop() : base("Basalt Top")
        {
            AddVersion("basalt_top")
                .MapsToJavaBlock<Java.Textures.Block.BasaltTop>();
        }
    }
}
