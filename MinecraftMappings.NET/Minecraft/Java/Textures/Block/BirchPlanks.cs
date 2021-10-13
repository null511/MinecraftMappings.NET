using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BirchPlanks : JavaBlockTexture
    {
        public BirchPlanks() : base("Birch Planks")
        {
            AddVersion("birch_planks")
                .MapsToBedrockBlock<BedrockBlocks.PlanksBirch>();
        }
    }
}
