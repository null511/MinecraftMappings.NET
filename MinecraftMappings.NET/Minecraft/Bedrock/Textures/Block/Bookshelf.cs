using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class Bookshelf : BedrockBlockTexture
    {
        public Bookshelf() : base("Bookshelf")
        {
            AddVersion("bookshelf")
                .MapsToJavaBlock<Java.Textures.Block.Bookshelf>();
        }
    }
}
