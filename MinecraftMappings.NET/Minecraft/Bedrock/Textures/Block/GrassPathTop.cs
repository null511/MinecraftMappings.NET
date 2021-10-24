using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class GrassPathTop : BedrockBlockTexture
    {
        public GrassPathTop() : base("Grass Path Top")
        {
            AddVersion("grass_path_top")
                .MapsToJavaBlock<Java.Textures.Block.GrassPathTop>();
        }
    }
}
