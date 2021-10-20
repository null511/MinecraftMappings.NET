using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaLeaves : JavaBlockTexture
    {
        public AcaciaLeaves() : base("Acacia Leaves")
        {
            AddVersion("acacia_leaves")
                .WithDefaultModel<Java.Models.Block.AcaciaLeaves>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LeavesAcacia>();
        }
    }
}
