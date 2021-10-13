using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlackWool : JavaBlockTexture
    {
        public BlackWool() : base("Black Wool")
        {
            AddVersion("black_wool")
                .MapsToBedrockBlock<BedrockBlocks.WoolColoredBlack>();
        }
    }
}
