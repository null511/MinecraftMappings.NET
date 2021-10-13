using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DarkOakLeaves : JavaBlockTexture
    {
        public DarkOakLeaves() : base("Dark Oak Leaves")
        {
            AddVersion("dark_oak_leaves")
                .WithDefaultModel<Java.Models.Block.DarkOakLeaves>();
                //.MapsToBedrockBlock<BedrockBlocks.LeavesDarkOak>();
        }
    }
}
