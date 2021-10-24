using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class GrassTop : BedrockBlockTexture
    {
        public GrassTop() : base("Grass Top")
        {
            AddVersion("grass_top")
                .MapsToJavaBlock<Java.Textures.Block.GrassBlockTop>();
        }
    }
}
