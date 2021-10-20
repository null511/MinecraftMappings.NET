using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlueGlazedTerracotta : JavaBlockTexture
    {
        public BlueGlazedTerracotta() : base("Blue Glazed Terracotta")
        {
            AddVersion("blue_glazed_terracotta")
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlazedTerracottaBlue>();
        }
    }
}
