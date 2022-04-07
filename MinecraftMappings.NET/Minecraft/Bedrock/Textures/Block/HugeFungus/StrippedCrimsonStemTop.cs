using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.HugeFungus
{
    public class StrippedCrimsonStemTop : BedrockBlockTexture
    {
        public StrippedCrimsonStemTop() : base("Stripped Crimson Stem Top")
        {
            AddVersion("stripped_crimson_stem_top")
                .MapsToJavaBlock<Java.Textures.Block.StrippedCrimsonStemTop>();
        }
    }
}
