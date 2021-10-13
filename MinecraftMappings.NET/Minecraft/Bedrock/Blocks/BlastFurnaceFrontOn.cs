using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BlastFurnaceFrontOn : BedrockBlockTexture
    {
        public BlastFurnaceFrontOn() : base("Blast Furnace Front, On")
        {
            AddVersion("blast_furnace_front_on")
                .WithFrameCount(2)
                .MapsToJavaBlock<Java.Textures.Block.BlastFurnaceFrontOn>();
        }
    }
}
