using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlackStainedGlass : JavaBlockTexture
    {
        public BlackStainedGlass() : base("Black Stained Glass")
        {
            AddVersion("black_stained_glass")
                .MapsToBedrockBlock<BedrockBlocks.GlassBlack>();
        }
    }
}
