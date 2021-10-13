using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlastFurnaceFront : JavaBlockTexture
    {
        public BlastFurnaceFront() : base("Blast Furnace Front")
        {
            AddVersion("blast_furnace_front")
                //.WithDefaultModel<Java.Models.Block.BlastFurnace>()
                .MapsToBedrockBlock<BedrockBlocks.BlastFurnaceFrontOff>();
        }
    }
}
