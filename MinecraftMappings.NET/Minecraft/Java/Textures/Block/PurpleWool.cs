using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PurpleWool : JavaBlockTexture
    {
        public PurpleWool() : base("Purple Wool")
        {
            AddVersion("purple_wool");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WoolColoredPurple>();
        }
    }
}
