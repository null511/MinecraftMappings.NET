using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class FlowerDandelion : BedrockBlockTexture
    {
        public FlowerDandelion() : base("Flower, Dandelion")
        {
            AddVersion("flower_dandelion")
                .MapsToJavaBlock<Java.Textures.Block.Dandelion>();
        }
    }
}
