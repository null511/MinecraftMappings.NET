using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrownGlazedTerracotta : JavaBlockTexture
    {
        public BrownGlazedTerracotta() : base("Brown Glazed Terracotta")
        {
            AddVersion("brown_glazed_terracotta")
                .MapsToBedrockBlock<BedrockBlocks.GlazedTerracottaBrown>();
        }
    }
}
