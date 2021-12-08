using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class FloweringAzaleaLeaves : JavaBlockTexture
    {
        public FloweringAzaleaLeaves() : base("Flowering Azalea Leaves")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(7, "flowering_azalea_leaves")
                .WithMinVersion("1.17")
                .WithDefaultModel<Java.Models.Block.FloweringAzaleaLeaves>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LeavesAzaleaFlowering>();
        }
    }
}
