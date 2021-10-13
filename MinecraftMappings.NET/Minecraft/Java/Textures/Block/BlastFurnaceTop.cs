using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlastFurnaceTop : JavaBlockTexture
    {
        public BlastFurnaceTop() : base("Blast Furnace, Top")
        {
            AddVersion("blast_furnace_top")
                //.WithDefaultModel<Java.Models.Block.BlastFurnace>()
                .MapsToBedrockBlock<BedrockBlocks.BlastFurnaceTop>();
        }
    }
}
