using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlastFurnaceFrontOn : JavaBlockTexture
    {
        public BlastFurnaceFrontOn() : base("Blast Furnace Front, On")
        {
            AddVersion("blast_furnace_front_on")
                .WithFrameCount(2)
                //.WithDefaultModel<Java.Models.Block.BlastFurnace>()
                .MapsToBedrockBlock<BedrockBlocks.BlastFurnaceFrontOn>();
        }
    }
}
