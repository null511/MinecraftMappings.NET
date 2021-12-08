using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CyanWool : JavaBlockTexture
    {
        public CyanWool() : base("Cyan Wool")
        {
            AddVersion("cyan_wool");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WoolColoredCyan>();
        }
    }
}
