using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WhiteTerracotta : JavaBlockTexture
    {
        public WhiteTerracotta() : base("White Terracotta")
        {
            AddVersion("white_terracotta");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.HardenedClayStainedWhite>();
        }
    }
}
