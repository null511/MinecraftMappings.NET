using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.HugeFungus
{
    public class StrippedWarpedStemSide : BedrockBlockTexture
    {
        public StrippedWarpedStemSide() : base("Stripped Warped Stem Side")
        {
            AddVersion("stripped_warped_stem_side")
                .MapsToJavaBlock<Java.Textures.Block.StrippedWarpedStem>();
        }
    }
}
