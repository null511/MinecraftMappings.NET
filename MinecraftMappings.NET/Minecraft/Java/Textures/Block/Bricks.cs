using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Bricks : JavaBlockData
    {
        public Bricks() : base("Bricks")
        {
            AddVersion("bricks")
                .MapsToBedrockBlock<BedrockBlocks.Brick>();
        }
    }
}
