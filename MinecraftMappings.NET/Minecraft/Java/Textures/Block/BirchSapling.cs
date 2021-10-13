using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BirchSapling : JavaBlockTexture
    {
        public BirchSapling() : base("Birch Sapling")
        {
            AddVersion("birch_sapling")
                .WithDefaultModel<Java.Models.Block.BirchSapling>()
                .MapsToBedrockBlock<BedrockBlocks.SaplingBirch>();
        }
    }
}
