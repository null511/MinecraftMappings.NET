using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class ShulkerTopBlack : BedrockBlockTexture
    {
        public ShulkerTopBlack() : base("Shulker Top Black")
        {
            AddVersion("shulker_top_black")
                .MapsToJavaBlock<Java.Textures.Block.BlackShulkerBox>();
        }
    }
}
