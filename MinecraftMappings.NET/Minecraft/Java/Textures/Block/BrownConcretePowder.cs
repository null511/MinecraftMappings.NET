using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrownConcretePowder : JavaBlockTexture
    {
        public BrownConcretePowder() : base("Brown Concrete Powder")
        {
            AddVersion("brown_concrete_powder")
                .MapsToBedrockBlock<BedrockBlocks.ConcretePowderBrown>();
        }
    }
}
