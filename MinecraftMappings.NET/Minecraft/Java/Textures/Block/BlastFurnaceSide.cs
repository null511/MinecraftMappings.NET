using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlastFurnaceSide : JavaBlockTexture
    {
        public BlastFurnaceSide() : base("Blast Furnace Side")
        {
            AddVersion("blast_furnace_side")
                .WithDefaultModel<Java.Models.Block.BlastFurnace>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BlastFurnaceSide>();
        }
    }
}
