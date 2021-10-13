using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Comparator_On : JavaBlockTexture
    {
        public Comparator_On() : base("Comparator, On")
        {
            AddVersion("comparator_on")
                .WithDefaultModel<Java.Models.Block.Comparator_On>();
                //.MapsToBedrockBlock<BedrockBlocks.Comparator_On>();
        }
    }
}
