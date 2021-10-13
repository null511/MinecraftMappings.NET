using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class FlowerBlueOrchid : BedrockBlockTexture
    {
        public FlowerBlueOrchid() : base("Flower Blue Orchid")
        {
            AddVersion("flower_blue_orchid")
                .MapsToJavaBlock<BlueOrchid>();
        }
    }
}
