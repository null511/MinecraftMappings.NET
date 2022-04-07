using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.HugeFungus
{
    public class WarpedStemSide : BedrockBlockTexture
    {
        public WarpedStemSide() : base("Warped Stem Side")
        {
            FrameCount = 5;

            AddVersion("warped_stem_side")
                .MapsToJavaBlock<Java.Textures.Block.WarpedStem>();
        }
    }
}
