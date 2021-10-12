using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrewingStandBase : JavaBlockData
    {
        public BrewingStandBase() : base("Brewing Stand Base")
        {
            AddVersion("brewing_stand_base")
                .WithDefaultModel<Java.Models.Block.BrewingStand>()
                .MapsToBedrockBlock<BedrockBlocks.BrewingStandBase>();
        }
    }
}
