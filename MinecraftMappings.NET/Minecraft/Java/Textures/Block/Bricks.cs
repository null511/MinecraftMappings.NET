using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Bricks : JavaBlockTexture
    {
        public Bricks() : base("Bricks")
        {
            AddVersion("bricks")
                .MapsToBedrockBlock<BedrockBlocks.Brick>();
        }
    }
}
