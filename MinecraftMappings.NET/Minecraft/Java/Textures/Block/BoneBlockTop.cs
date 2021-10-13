using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BoneBlockTop : JavaBlockTexture
    {
        public BoneBlockTop() : base("Bone Block Top")
        {
            AddVersion("bone_block_top")
                .MapsToBedrockBlock<BedrockBlocks.BoneBlockTop>();
        }
    }
}
