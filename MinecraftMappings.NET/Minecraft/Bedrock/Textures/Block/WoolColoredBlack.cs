using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class WoolColoredBlack : BedrockBlockTexture
    {
        public WoolColoredBlack() : base("Wool Colored Black")
        {
            AddVersion("wool_colored_black")
                .MapsToJavaBlock<BlackWool>();
        }
    }
}
