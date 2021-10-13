using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BlastFurnaceSide : BedrockBlockTexture
    {
        public BlastFurnaceSide() : base("Blast Furnace Side")
        {
            AddVersion("blast_furnace_side")
                .MapsToJavaBlock<Java.Textures.Block.BlastFurnaceSide>();
        }
    }
}
