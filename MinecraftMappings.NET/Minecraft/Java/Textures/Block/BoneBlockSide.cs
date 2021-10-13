using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BoneBlockSide : JavaBlockTexture
    {
        public BoneBlockSide() : base("Bone Block Side")
        {
            AddVersion("bone_block_side")
                .MapsToBedrockBlock<BedrockBlocks.BoneBlockSide>();
        }
    }
}
