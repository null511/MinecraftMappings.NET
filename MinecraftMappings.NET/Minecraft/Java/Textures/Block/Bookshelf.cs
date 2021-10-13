using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Bookshelf : JavaBlockTexture
    {
        public Bookshelf() : base("Bookshelf")
        {
            AddVersion("bookshelf")
                //.WithDefaultModel<Java.Models.Block.Bookshelf>()
                .MapsToBedrockBlock<BedrockBlocks.Bookshelf>();
        }
    }
}
