using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Comparator : JavaBlockData
    {
        public Comparator() : base("Comparator")
        {
            AddVersion("comparator")
                .WithDefaultModel<Java.Models.Block.Comparator>();
                //.MapsToBedrockBlock<BedrockBlocks.Comparator>();
        }
    }
}
