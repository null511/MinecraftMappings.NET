using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class StrippedWarpedStemTop : JavaBlockTexture
    {
        public StrippedWarpedStemTop() : base("Stripped Warped Stem Top")
        {
            AddVersion("stripped_warped_stem_top")
                .WithDefaultModel<Java.Models.Block.StrippedWarpedStem>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.StrippedWarpedStemTop>();
        }
    }
}
