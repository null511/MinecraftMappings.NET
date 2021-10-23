using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class HoneyBlockTop : JavaBlockTexture
    {
        public HoneyBlockTop() : base("Honey Block Top")
        {
            AddVersion("honey_block_top")
                .WithMinVersion("1.15")
                .WithDefaultModel<Java.Models.Block.HoneyBlock>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.HoneyTop>();
        }
    }
}
