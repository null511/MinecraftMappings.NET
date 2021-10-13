using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BellTop : JavaBlockTexture
    {
        public BellTop() : base("Bell Top")
        {
            AddVersion("bell_top")
                .MapsToBedrockBlock<BedrockBlocks.BellTop>();
        }
    }
}
