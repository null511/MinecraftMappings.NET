using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.HugeFungus
{
    public class WarpedStemTop : BedrockBlockTexture
    {
        public WarpedStemTop() : base("Warped Stem Top")
        {
            AddVersion("warped_stem_top")
                .MapsToJavaBlock<Java.Textures.Block.WarpedStemTop>();
        }
    }
}
