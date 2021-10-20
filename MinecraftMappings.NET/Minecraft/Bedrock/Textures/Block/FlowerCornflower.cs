using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class FlowerCornflower : BedrockBlockTexture
    {
        public FlowerCornflower() : base("Flower, Cornflower")
        {
            AddVersion("flower_cornflower")
                .MapsToJavaBlock<Java.Textures.Block.Cornflower>();
        }
    }
}
