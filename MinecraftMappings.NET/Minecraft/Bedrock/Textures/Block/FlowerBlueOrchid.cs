using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class FlowerBlueOrchid : BedrockBlockTexture
    {
        public FlowerBlueOrchid() : base("Flower Blue Orchid")
        {
            AddVersion("flower_blue_orchid")
                .MapsToJavaBlock<Java.Textures.Block.BlueOrchid>();
        }
    }
}
