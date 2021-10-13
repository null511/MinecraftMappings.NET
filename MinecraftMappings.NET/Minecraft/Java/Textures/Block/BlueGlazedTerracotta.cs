using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlueGlazedTerracotta : JavaBlockTexture
    {
        public BlueGlazedTerracotta() : base("Blue Glazed Terracotta")
        {
            AddVersion("blue_glazed_terracotta")
                .MapsToBedrockBlock<BedrockBlocks.GlazedTerracottaBlue>();
        }
    }
}
