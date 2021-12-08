using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LimeWool : JavaBlockTexture
    {
        public LimeWool() : base("Lime Wool")
        {
            AddVersion("lime_wool");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WoolColoredLime>();
        }
    }
}
