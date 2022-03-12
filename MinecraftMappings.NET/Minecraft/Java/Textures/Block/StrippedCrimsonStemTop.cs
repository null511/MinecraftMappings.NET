using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class StrippedCrimsonStemTop : JavaBlockTexture
    {
        public StrippedCrimsonStemTop() : base("Stripped Crimson Stem Top")
        {
            AddVersion("stripped_crimson_stem_top")
                .WithDefaultModel<Java.Models.Block.StrippedCrimsonStem>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.StrippedCrimsonStemTop>();
        }
    }
}
