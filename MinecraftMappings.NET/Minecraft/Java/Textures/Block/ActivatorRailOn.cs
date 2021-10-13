using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ActivatorRailOn : JavaBlockTexture
    {
        public ActivatorRailOn() : base("Activator Rail, On")
        {
            AddVersion("activator_rail_on")
                .WithDefaultModel<Java.Models.Block.ActivatorRailOn>()
                .MapsToBedrockBlock<BedrockBlocks.RailActivatorPowered>();
        }
    }
}
