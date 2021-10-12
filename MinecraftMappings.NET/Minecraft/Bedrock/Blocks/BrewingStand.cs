using MinecraftMappings.Internal.Blocks;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BrewingStand : BedrockBlockData
    {
        public BrewingStand() : base("Brewing Stand")
        {
            AddVersion("brewing_stand")
                .MapsToJavaBlock<Java.Textures.Block.BrewingStand>();
        }
    }
}
