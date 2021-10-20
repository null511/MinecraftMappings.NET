using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class GlazedTerracottaBlue : BedrockBlockTexture
    {
        public GlazedTerracottaBlue() : base("Glazed Terracotta Blue")
        {
            AddVersion("glazed_terracotta_blue")
                .MapsToJavaBlock<BlueGlazedTerracotta>();
        }
    }
}
