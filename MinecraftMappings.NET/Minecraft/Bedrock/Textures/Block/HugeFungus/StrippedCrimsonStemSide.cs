using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.HugeFungus
{
    public class StrippedCrimsonStemSide : BedrockBlockTexture
    {
        public StrippedCrimsonStemSide() : base("Stripped Crimson Stem Side")
        {
            AddVersion("stripped_crimson_stem_side")
                .MapsToJavaBlock<Java.Textures.Block.StrippedCrimsonStem>();
        }
    }
}
