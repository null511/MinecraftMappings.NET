using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Bedrock.Textures.Block.HugeFungus;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CrimsonStem : JavaBlockTexture
    {
        public CrimsonStem() : base("Crimson Stem")
        {
            AddVersion("crimson_stem")
                .WithMinVersion("1.16")
                .WithDefaultModel<Java.Models.Block.CrimsonStem>()
                .MapsToBedrockBlock<CrimsonLogSide>();
        }
    }
}
