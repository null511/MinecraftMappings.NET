using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class YellowWool : JavaBlockTexture
    {
        public YellowWool() : base("Yellow Wool")
        {
            AddVersion("yellow_wool")
                .WithMinVersion("1.6.1");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WoolColoredYellow>();
        }
    }
}
