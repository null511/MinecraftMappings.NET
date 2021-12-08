using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BambooSingleLeaf : JavaBlockTexture
    {
        public BambooSingleLeaf() : base("Bamboo, Single Leaf")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(4, "bamboo_singleleaf")
                .WithMinVersion("1.14");
                //.WithDefaultModel<Java.Models.Block.Bamboo1_Age0>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BambooSingleLeaf>();
        }
    }
}
