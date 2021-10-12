using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrownConcretePowder : JavaBlockData
    {
        public const string BlockId = "brown_concrete_powder";
        public const string BlockName = "Brown Concrete Powder";


        public BrownConcretePowder() : base(BlockName)
        {
            AddVersion(BlockId, version => {
                version.MapsToBedrockId = BedrockBlocks.ConcretePowderBrown.BlockId;
            });
        }
    }
}
