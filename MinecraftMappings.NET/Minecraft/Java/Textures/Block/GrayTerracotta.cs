using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GrayTerracotta : JavaBlockTexture
    {
        public GrayTerracotta() : base("Gray Terracotta")
        {
            AddVersion("gray_terracotta");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.HardenedClayStainedGray>();
        }
    }
}
