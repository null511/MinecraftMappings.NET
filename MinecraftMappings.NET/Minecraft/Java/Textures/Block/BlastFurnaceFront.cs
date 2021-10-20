using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlastFurnaceFront : JavaBlockTexture
    {
        public BlastFurnaceFront() : base("Blast Furnace Front")
        {
            AddVersion("blast_furnace_front")
                .WithDefaultModel<Java.Models.Block.BlastFurnace>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BlastFurnaceFrontOff>();
        }
    }
}
