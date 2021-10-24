using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class GrassSide : BedrockBlockTexture
    {
        public GrassSide() : base("Grass Side")
        {
            AddVersion("grass_side")
                .MapsToJavaBlock<Java.Textures.Block.GrassBlockSide>();
        }
    }
}
