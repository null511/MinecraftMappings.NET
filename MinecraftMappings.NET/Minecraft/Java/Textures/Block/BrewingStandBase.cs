using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrewingStandBase : JavaBlockTexture
    {
        public BrewingStandBase() : base("Brewing Stand Base")
        {
            AddVersion("brewing_stand_base")
                .WithDefaultModel<Java.Models.Block.BrewingStand>()
                .MapsToBedrockBlock<BedrockBlocks.BrewingStandBase>();
        }
    }
}
