using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class Vine : BedrockBlockTexture
    {
        public Vine() : base("Vine")
        {
            AddVersion("vine")
                .MapsToJavaBlock<Java.Textures.Block.Vine>();
        }
    }
}
