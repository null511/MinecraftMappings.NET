using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Bookshelf : JavaBlockTexture
    {
        public Bookshelf() : base("Bookshelf")
        {
            AddVersion("bookshelf")
                .WithDefaultModel<Java.Models.Block.Bookshelf>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Bookshelf>();
        }
    }
}
