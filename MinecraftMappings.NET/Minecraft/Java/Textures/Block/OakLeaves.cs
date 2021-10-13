using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OakLeaves : JavaBlockTexture
    {
        public OakLeaves() : base("Oak Leaves")
        {
            AddVersion("oak_leaves")
                .WithDefaultModel<Java.Models.Block.OakLeaves>();
                //.MapsToBedrockBlock<BedrockBlocks.LeavesOak>();
        }
    }
}
