using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class GlazedTerracottaBlack : BedrockBlockTexture
    {
        public GlazedTerracottaBlack() : base("Glazed Terracotta Black")
        {
            AddVersion("glazed_terracotta_black")
                .MapsToJavaBlock<BlackGlazedTerracotta>();
        }
    }
}
