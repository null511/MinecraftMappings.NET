using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlueGlazedTerracotta : JavaBlockTexture
    {
        public BlueGlazedTerracotta() : base("Blue Glazed Terracotta")
        {
            AddVersion("blue_glazed_terracotta")
                .WithDefaultModel<Java.Models.Block.BlueGlazedTerracotta>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlazedTerracottaBlue>();
        }
    }
}
