using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SpruceLeaves : JavaBlockTexture
    {
        public SpruceLeaves() : base("Spruce Leaves")
        {
            AddVersion("spruce_leaves")
                .WithDefaultModel<Java.Models.Block.SpruceLeaves>();
                //.MapsToBedrockBlock<BedrockBlocks.LeavesSpruce>();
        }
    }
}
