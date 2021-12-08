using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LightGrayWool : JavaBlockTexture
    {
        public LightGrayWool() : base("Light Gray Wool")
        {
            AddVersion("light_gray_wool");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WoolColoredLightGray>();
        }
    }
}
