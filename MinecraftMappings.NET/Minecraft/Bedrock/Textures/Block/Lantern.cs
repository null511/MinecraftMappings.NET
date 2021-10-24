using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class Lantern : BedrockBlockTexture
    {
        public Lantern() : base("Lantern")
        {
            AddVersion("lantern")
                .MapsToJavaBlock<Java.Textures.Block.Lantern>();
        }
    }
}
