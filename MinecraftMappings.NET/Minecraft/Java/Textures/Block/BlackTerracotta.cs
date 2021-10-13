using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlackTerracotta : JavaBlockTexture
    {
        public BlackTerracotta() : base("Black Terracotta")
        {
            AddVersion("black_terracotta")
                .MapsToBedrockBlock<BedrockBlocks.HardenedClayStainedBlack>();
        }
    }
}
