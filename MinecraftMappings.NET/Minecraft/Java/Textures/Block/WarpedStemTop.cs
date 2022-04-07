using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WarpedStemTop : JavaBlockTexture
    {
        public WarpedStemTop() : base("Warped Stem, Top")
        {
            AddVersion("warped_stem_top")
                .WithMinVersion("1.16")
                .WithDefaultModel<Java.Models.Block.WarpedStem>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.HugeFungus.WarpedStemTop>();
        }
    }
}
