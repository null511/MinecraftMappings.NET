using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class GlazedTerracottaBrown : BedrockBlockTexture
    {
        public GlazedTerracottaBrown() : base("Glazed Terracotta Brown")
        {
            AddVersion("glazed_terracotta_brown")
                .MapsToJavaBlock<Java.Textures.Block.BrownGlazedTerracotta>();
        }
    }
}
