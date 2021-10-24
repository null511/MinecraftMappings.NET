using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class FlowerWhiteTulip : BedrockBlockTexture
    {
        public FlowerWhiteTulip() : base("Flower, White Tulip")
        {
            AddVersion("flower_tulip_white")
                .MapsToJavaBlock<Java.Textures.Block.WhiteTulip>();
        }
    }
}
