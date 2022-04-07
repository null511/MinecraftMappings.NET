using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class GlazedTerracottaBlue : BedrockBlockTexture
    {
        public GlazedTerracottaBlue() : base("Glazed Terracotta Blue")
        {
            AddVersion("glazed_terracotta_blue")
                .MapsToJavaBlock<Java.Textures.Block.BlueGlazedTerracotta>();
        }
    }
}
