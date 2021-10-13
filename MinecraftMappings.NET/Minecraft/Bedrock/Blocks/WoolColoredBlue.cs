using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class WoolColoredBlue : BedrockBlockTexture
    {
        public WoolColoredBlue() : base("Wool Colored, Blue")
        {
            AddVersion("wool_colored_blue")
                .MapsToJavaBlock<BlueWool>();
        }
    }
}
