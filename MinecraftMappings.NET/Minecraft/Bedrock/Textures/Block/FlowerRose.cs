using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class FlowerRose : BedrockBlockTexture
    {
        public FlowerRose() : base("Flower, Rose")
        {
            AddVersion("flower_rose")
                .MapsToJavaBlock<Java.Textures.Block.Poppy>();
        }
    }
}
