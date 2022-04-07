using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.HugeFungus
{
    public class StrippedWarpedStemTop : BedrockBlockTexture
    {
        public StrippedWarpedStemTop() : base("Stripped Warped Stem Top")
        {
            AddVersion("stripped_warped_stem_top")
                .MapsToJavaBlock<Java.Textures.Block.StrippedWarpedStemTop>();
        }
    }
}
