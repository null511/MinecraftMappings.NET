using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlastFurnaceSide : JavaBlockTexture
    {
        public BlastFurnaceSide() : base("Blast Furnace Side")
        {
            AddVersion("blast_furnace_side")
                //.WithDefaultModel<Java.Models.Block.BlastFurnace>()
                .MapsToBedrockBlock<BedrockBlocks.BlastFurnaceSide>();
        }
    }
}
