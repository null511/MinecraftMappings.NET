using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class FlowerOrangeTulip : BedrockBlockTexture
    {
        public FlowerOrangeTulip() : base("Flower, Orange Tulip")
        {
            AddVersion("flower_tulip_orange")
                .MapsToJavaBlock<Java.Textures.Block.OrangeTulip>();
        }
    }
}
