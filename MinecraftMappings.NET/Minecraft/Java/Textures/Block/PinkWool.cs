using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PinkWool : JavaBlockTexture
    {
        public PinkWool() : base("Pink Wool")
        {
            AddVersion("pink_wool");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WoolColoredPink>();
        }
    }
}
