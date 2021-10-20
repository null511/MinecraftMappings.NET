using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class GlassBlue : BedrockBlockTexture
    {
        public GlassBlue() : base("Glass Blue")
        {
            AddVersion("glass_blue")
                .MapsToJavaBlock<BlueStainedGlass>();
        }
    }
}
