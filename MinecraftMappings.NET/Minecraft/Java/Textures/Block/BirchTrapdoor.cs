using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BirchTrapdoor : JavaBlockTexture
    {
        public BirchTrapdoor() : base("Birch Trapdoor")
        {
            AddVersion("birch_trapdoor")
                .WithDefaultModel<Java.Models.Block.BirchTrapdoorTop>()
                .MapsToBedrockBlock<BedrockBlocks.BirchTrapdoor>();
        }
    }
}
