using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlackGlazedTerracotta : JavaBlockTexture
    {
        public BlackGlazedTerracotta() : base("Black Glazed Terracotta")
        {
            AddVersion("black_glazed_terracotta")
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlazedTerracottaBlack>();
        }
    }
}
