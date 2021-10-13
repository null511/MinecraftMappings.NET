using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Comparator : JavaBlockTexture
    {
        public Comparator() : base("Comparator")
        {
            AddVersion("comparator")
                .WithDefaultModel<Java.Models.Block.Comparator>();
                //.MapsToBedrockBlock<BedrockBlocks.Comparator>();
        }
    }
}
