using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SpruceLeaves : JavaBlockData
    {
        public SpruceLeaves() : base("Spruce Leaves")
        {
            AddVersion("spruce_leaves")
                .WithDefaultModel<Java.Models.Block.SpruceLeaves>();
                //.MapsToBedrockBlock<BedrockBlocks.LeavesSpruce>();
        }
    }
}
