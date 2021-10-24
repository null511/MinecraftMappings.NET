using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class GrassPathSide : BedrockBlockTexture
    {
        public GrassPathSide() : base("Grass Path Side")
        {
            AddVersion("grass_path_side")
                .MapsToJavaBlock<Java.Textures.Block.GrassPathSide>();
        }
    }
}
