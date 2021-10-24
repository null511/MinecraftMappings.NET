using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class GrassSideSnowed : BedrockBlockTexture
    {
        public GrassSideSnowed() : base("Grass Side, Snowed")
        {
            AddVersion("grass_side_snowed")
                .MapsToJavaBlock<Java.Textures.Block.GrassBlockSnow>();
        }
    }
}
