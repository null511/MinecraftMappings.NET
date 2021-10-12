using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BirchLeaves : JavaBlockData
    {
        public BirchLeaves() : base("Birch Leaves")
        {
            AddVersion("birch_leaves")
                .WithDefaultModel<Java.Models.Block.BirchLeaves>()
                .MapsToBedrockBlock<BedrockBlocks.LeavesBirch>();
        }
    }
}
