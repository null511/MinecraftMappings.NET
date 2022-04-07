using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Bedrock.Textures.Block.HugeFungus;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CrimsonStemTop : JavaBlockTexture
    {
        public CrimsonStemTop() : base("Crimson Stem, Top")
        {
            AddVersion("crimson_stem_top")
                .WithMinVersion("1.16")
                .WithDefaultModel<Java.Models.Block.CrimsonStem>()
                .MapsToBedrockBlock<CrimsonLogTop>();
        }
    }
}
