using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BoneBlockSide : JavaBlockTexture
    {
        public BoneBlockSide() : base("Bone Block Side")
        {
            AddVersion("bone_block_side")
                .WithDefaultModel<Java.Models.Block.BoneBlock>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BoneBlockSide>();
        }
    }
}
