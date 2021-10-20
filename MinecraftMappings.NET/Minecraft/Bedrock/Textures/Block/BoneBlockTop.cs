using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class BoneBlockTop : BedrockBlockTexture
    {
        public BoneBlockTop() : base("Bone Block Top")
        {
            AddVersion("bone_block_top")
                .MapsToJavaBlock<Java.Textures.Block.BoneBlockTop>();
        }
    }
}
