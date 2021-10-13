using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BlastFurnaceTop : BedrockBlockTexture
    {
        public BlastFurnaceTop() : base("Blast Furnace Top")
        {
            AddVersion("blast_furnace_top")
                .MapsToJavaBlock<Java.Textures.Block.BlastFurnaceTop>();
        }
    }
}
