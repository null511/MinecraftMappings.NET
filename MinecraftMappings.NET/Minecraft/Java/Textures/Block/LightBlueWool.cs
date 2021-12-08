using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LightBlueWool : JavaBlockTexture
    {
        public LightBlueWool() : base("Light Blue Wool")
        {
            AddVersion("light_blue_wool");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WoolColoredLightBlue>();
        }
    }
}
