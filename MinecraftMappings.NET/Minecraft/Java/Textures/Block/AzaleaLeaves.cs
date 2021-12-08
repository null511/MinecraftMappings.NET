using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AzaleaLeaves : JavaBlockTexture
    {
        public AzaleaLeaves() : base("Azalea Leaves")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(7, "azalea_leaves")
                .WithMinVersion("1.17")
                .WithDefaultModel<Java.Models.Block.AzaleaLeaves>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LeavesAzalea>();
        }
    }
}
