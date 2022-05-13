using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WhiteGlazedTerracotta : JavaBlockTexture
    {
        public WhiteGlazedTerracotta() : base("White Glazed Terracotta")
        {
            AddVersion("white_glazed_terracotta")
                .WithDefaultModel<Java.Models.Block.WhiteGlazedTerracotta>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlazedTerracottaWhite>();
        }
    }
}
