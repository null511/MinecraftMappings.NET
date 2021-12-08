using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrownWool : JavaBlockTexture
    {
        public BrownWool() : base("Brown Wool")
        {
            AddVersion("brown_wool");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WoolColoredBrown>();
        }
    }
}
