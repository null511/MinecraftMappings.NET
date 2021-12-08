using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SpruceLeaves : JavaBlockTexture
    {
        public SpruceLeaves() : base("Spruce Leaves")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("spruce_leaves")
                .WithDefaultModel<Java.Models.Block.SpruceLeaves>();
                //.MapsToBedrockBlock<BedrockBlocks.LeavesSpruce>();
        }
    }
}
