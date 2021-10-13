using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlackGlazedTerracotta : JavaBlockTexture
    {
        public BlackGlazedTerracotta() : base("Black Glazed Terracotta")
        {
            AddVersion("black_glazed_terracotta")
                .MapsToBedrockBlock<BedrockBlocks.GlazedTerracottaBlack>();
        }
    }
}
