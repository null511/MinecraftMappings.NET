using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BirchSapling : JavaBlockData
    {
        public BirchSapling() : base("Birch Sapling")
        {
            AddVersion("birch_sapling")
                .WithDefaultModel<Java.Models.Block.BirchSapling>()
                .MapsToBedrockBlock<BedrockBlocks.SaplingBirch>();
        }
    }
}
