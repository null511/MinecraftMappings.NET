using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class YellowGlazedTerracotta : JavaBlockTexture
    {
        public YellowGlazedTerracotta() : base("Yellow Glazed Terracotta")
        {
            AddVersion("yellow_glazed_terracotta")
                .WithDefaultModel<Java.Models.Block.YellowGlazedTerracotta>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlazedTerracottaYellow>();
        }
    }
}
