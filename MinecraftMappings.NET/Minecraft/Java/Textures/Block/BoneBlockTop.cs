using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BoneBlockTop : JavaBlockTexture
    {
        public BoneBlockTop() : base("Bone Block Top")
        {
            AddVersion("bone_block_top")
                .WithDefaultModel<Java.Models.Block.BoneBlock>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BoneBlockTop>();
        }
    }
}
