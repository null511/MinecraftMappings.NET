using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrewingStand : JavaBlockData
    {
        public BrewingStand() : base("Brewing Stand")
        {
            AddVersion("brewing_stand")
                .WithDefaultModel<Java.Models.Block.BrewingStand>()
                .MapsToBedrockBlock<BedrockBlocks.BrewingStand>();
        }
    }
}
