using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BambooSmallLeaves : JavaBlockTexture
    {
        public BambooSmallLeaves() : base("Bamboo, Small Leaves")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(4, "bamboo_small_leaves")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.BambooSmallLeaves>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BambooStem>();
        }
    }
}
