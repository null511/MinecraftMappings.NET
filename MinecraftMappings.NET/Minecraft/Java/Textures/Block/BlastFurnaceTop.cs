using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlastFurnaceTop : JavaBlockTexture
    {
        public BlastFurnaceTop() : base("Blast Furnace, Top")
        {
            AddVersion("blast_furnace_top")
                .WithDefaultModel<Java.Models.Block.BlastFurnace>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BlastFurnaceTop>();
        }
    }
}
