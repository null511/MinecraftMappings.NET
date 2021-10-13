using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BrewingStand : BedrockBlockTexture
    {
        public BrewingStand() : base("Brewing Stand")
        {
            AddVersion("brewing_stand")
                .MapsToJavaBlock<Java.Textures.Block.BrewingStand>();
        }
    }
}
