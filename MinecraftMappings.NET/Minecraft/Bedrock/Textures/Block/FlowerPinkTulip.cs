using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class FlowerPinkTulip : BedrockBlockTexture
    {
        public FlowerPinkTulip() : base("Flower, Pink Tulip")
        {
            AddVersion("flower_tulip_pink")
                .MapsToJavaBlock<Java.Textures.Block.PinkTulip>();
        }
    }
}
