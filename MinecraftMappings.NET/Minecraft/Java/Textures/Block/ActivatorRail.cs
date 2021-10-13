using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ActivatorRail : JavaBlockTexture
    {
        public ActivatorRail() : base("Activator Rail")
        {
            AddVersion("activator_rail")
                .WithDefaultModel<Java.Models.Block.ActivatorRail>()
                .MapsToBedrockBlock<BedrockBlocks.RailActivator>();
        }
    }
}
