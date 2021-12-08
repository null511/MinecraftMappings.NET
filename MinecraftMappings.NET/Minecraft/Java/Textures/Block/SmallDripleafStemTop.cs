using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SmallDripleafStemTop : JavaBlockTexture
    {
        public SmallDripleafStemTop() : base("Small Dripleaf Stem Top")
        {
            AddVersion(7, "small_dripleaf_stem_top")
                .WithMinVersion("1.17");
                //.WithDefaultModel<Java.Models.Block.SmallDripleafStem>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.SmallDripleafStemTop>();
        }
    }
}
