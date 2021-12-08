using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OrangeWool : JavaBlockTexture
    {
        public OrangeWool() : base("Orange Wool")
        {
            AddVersion("orange_wool");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WoolColoredOrange>();
        }
    }
}
