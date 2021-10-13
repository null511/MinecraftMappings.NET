using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlackConcretePowder : JavaBlockTexture
    {
        public BlackConcretePowder() : base("Black Concrete Powder")
        {
            AddVersion("black_concrete_powder")
                .MapsToBedrockBlock<BedrockBlocks.ConcretePowderBlack>();
        }
    }
}
