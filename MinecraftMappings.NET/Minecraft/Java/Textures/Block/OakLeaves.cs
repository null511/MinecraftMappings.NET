using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OakLeaves : JavaBlockTexture
    {
        public OakLeaves() : base("Oak Leaves")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("oak_leaves")
                .WithDefaultModel<Java.Models.Block.OakLeaves>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LeavesOak>();
        }
    }
}
