using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class FlowerRedTulip : BedrockBlockTexture
    {
        public FlowerRedTulip() : base("Flower, Red Tulip")
        {
            AddVersion("flower_tulip_red")
                .MapsToJavaBlock<Java.Textures.Block.RedTulip>();
        }
    }
}
