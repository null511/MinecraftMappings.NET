using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BirchTrapdoor : JavaBlockData
    {
        public BirchTrapdoor() : base("Birch Trapdoor")
        {
            AddVersion("birch_trapdoor")
                .WithDefaultModel<Java.Models.Block.BirchTrapdoorTop>()
                .MapsToBedrockBlock<BedrockBlocks.BirchTrapdoor>();
        }
    }
}
