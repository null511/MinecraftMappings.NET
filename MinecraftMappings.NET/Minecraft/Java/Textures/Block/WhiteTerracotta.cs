using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WhiteTerracotta : JavaBlockTexture
    {
        public WhiteTerracotta() : base("White Terracotta")
        {
            AddVersion("white_terracotta")
                .WithDefaultModel<Java.Models.Block.WhiteTerracotta>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.HardenedClayStainedWhite>();
        }
    }
}
