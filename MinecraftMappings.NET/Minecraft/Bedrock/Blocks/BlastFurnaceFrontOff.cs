using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BlastFurnaceFrontOff : BedrockBlockTexture
    {
        public BlastFurnaceFrontOff() : base("Blast Furnace Front, Off")
        {
            AddVersion("blast_furnace_front_off")
                .MapsToJavaBlock<BlastFurnaceFront>();
        }
    }
}
