using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaLeaves : JavaBlockTexture
    {
        public AcaciaLeaves() : base("Acacia Leaves")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(1, "acacia_leaves")
                .WithMinVersion("1.7.2")
                .WithDefaultModel<Java.Models.Block.AcaciaLeaves>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LeavesAcacia>();
        }
    }
}
