using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GrayWool : JavaBlockTexture
    {
        public GrayWool() : base("Gray Wool")
        {
            AddVersion("gray_wool");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WoolColoredGray>();
        }
    }
}
