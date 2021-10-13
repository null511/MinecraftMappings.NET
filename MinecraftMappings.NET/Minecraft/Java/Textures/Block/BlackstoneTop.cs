using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlackstoneTop : JavaBlockTexture
    {
        public BlackstoneTop() : base("Blackstone Top")
        {
            AddVersion("blackstone_top")
                .MapsToBedrockBlock<BedrockBlocks.BlackstoneTop>();
        }
    }
}
