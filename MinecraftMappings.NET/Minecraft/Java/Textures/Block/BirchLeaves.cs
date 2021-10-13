using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BirchLeaves : JavaBlockTexture
    {
        public BirchLeaves() : base("Birch Leaves")
        {
            AddVersion("birch_leaves")
                .WithDefaultModel<Java.Models.Block.BirchLeaves>()
                .MapsToBedrockBlock<BedrockBlocks.LeavesBirch>();
        }
    }
}
