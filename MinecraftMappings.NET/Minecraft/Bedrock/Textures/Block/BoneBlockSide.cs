using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class BoneBlockSide : BedrockBlockTexture
    {
        public BoneBlockSide() : base("Bone Block Side")
        {
            AddVersion("bone_block_side")
                .MapsToJavaBlock<Java.Textures.Block.BoneBlockSide>();
        }
    }
}
