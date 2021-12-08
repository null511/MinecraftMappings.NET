using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WhiteWool : JavaBlockTexture
    {
        public WhiteWool() : base("White Wool")
        {
            AddVersion("white_wool")
                .WithMinVersion("1.6.1");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WoolColoredWhite>();
        }
    }
}
