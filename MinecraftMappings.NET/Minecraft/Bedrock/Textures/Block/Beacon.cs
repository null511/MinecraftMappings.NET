using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class Beacon : BedrockBlockTexture
    {
        public Beacon() : base("Beacon")
        {
            AddVersion("beacon")
                .MapsToJavaBlock<Java.Textures.Block.Beacon>();
        }
    }
}
