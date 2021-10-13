using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaLeaves : JavaBlockTexture
    {
        public AcaciaLeaves() : base("Acacia Leaves")
        {
            AddVersion("acacia_leaves")
                .WithDefaultModel<Java.Models.Block.AcaciaLeaves>()
                .MapsToBedrockBlock<BedrockBlocks.LeavesAcacia>();
        }
    }
}
