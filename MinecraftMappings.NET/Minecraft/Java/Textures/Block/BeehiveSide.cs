using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeehiveSide : JavaBlockTexture
    {
        public BeehiveSide() : base("Beehive Side")
        {
            AddVersion("beehive_side")
                .WithDefaultModel<Java.Models.Block.Beehive>()
                .MapsToBedrockBlock<BedrockBlocks.BeehiveSide>();
        }
    }
}
