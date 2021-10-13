using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlueConcretePowder : JavaBlockTexture
    {
        public BlueConcretePowder() : base("Blue Concrete Powder")
        {
            AddVersion("blue_concrete_powder")
                .MapsToBedrockBlock<BedrockBlocks.ConcretePowderBlue>();
        }
    }
}
