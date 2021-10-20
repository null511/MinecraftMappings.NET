using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CrimsonStemTop : JavaBlockTexture
    {
        public CrimsonStemTop() : base("Crimson Stem, Top")
        {
            AddVersion("crimson_stem_top")
                .WithMinVersion("1.16")
                .WithDefaultModel<Java.Models.Block.CrimsonStem>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CrimsonStemTop>();
        }
    }
}
