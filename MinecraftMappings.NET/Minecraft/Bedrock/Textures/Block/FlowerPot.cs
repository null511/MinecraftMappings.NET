using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class FlowerPot : BedrockBlockTexture
    {
        public FlowerPot() : base("Flower Pot")
        {
            AddVersion("flower_pot")
                .MapsToJavaBlock<Java.Textures.Block.FlowerPot>();
        }
    }
}
