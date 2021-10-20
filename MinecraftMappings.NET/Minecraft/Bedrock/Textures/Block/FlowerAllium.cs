using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class FlowerAllium : BedrockBlockTexture
    {
        public FlowerAllium() : base("Flower Allium")
        {
            AddVersion("flower_allium")
                .MapsToJavaBlock<Allium>();
        }
    }
}
