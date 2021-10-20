using MinecraftMappings.Internal.Textures.Block;

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
