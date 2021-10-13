using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class ShulkerTopBlue : BedrockBlockTexture
    {
        public ShulkerTopBlue() : base("Shulker Top, Blue")
        {
            AddVersion("shulker_top_blue")
                .MapsToJavaBlock<Java.Textures.Block.BlueShulkerBox>();
        }
    }
}
