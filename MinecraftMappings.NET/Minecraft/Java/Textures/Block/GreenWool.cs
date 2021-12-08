using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GreenWool : JavaBlockTexture
    {
        public GreenWool() : base("Green Wool")
        {
            AddVersion("green_wool");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WoolColoredGreen>();
        }
    }
}
