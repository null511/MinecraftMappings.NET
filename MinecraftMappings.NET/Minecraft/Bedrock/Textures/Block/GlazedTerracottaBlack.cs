using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class GlazedTerracottaBlack : BedrockBlockTexture
    {
        public GlazedTerracottaBlack() : base("Glazed Terracotta Black")
        {
            AddVersion("glazed_terracotta_black")
                .MapsToJavaBlock<Java.Textures.Block.BlackGlazedTerracotta>();
        }
    }
}
