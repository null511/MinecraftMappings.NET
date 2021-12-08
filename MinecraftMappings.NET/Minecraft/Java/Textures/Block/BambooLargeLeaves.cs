using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BambooLargeLeaves : JavaBlockTexture
    {
        public BambooLargeLeaves() : base("Bamboo, Large Leaves")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(4, "bamboo_large_leaves")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.BambooLargeLeaves>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BambooStem>();
        }
    }
}
