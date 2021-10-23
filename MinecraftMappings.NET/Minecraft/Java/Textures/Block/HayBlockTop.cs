using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class HayBlockTop : JavaBlockTexture
    {
        public HayBlockTop() : base("Hay Block, Top")
        {
            AddVersion("hay_block_top")
                .WithMinVersion("1.6.1")
                .WithDefaultModel<Java.Models.Block.HayBlock>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.HayBlockTop>();
        }
    }
}
