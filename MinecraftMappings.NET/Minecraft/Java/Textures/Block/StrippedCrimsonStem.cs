using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class StrippedCrimsonStem : JavaBlockTexture
    {
        public StrippedCrimsonStem() : base("Stripped Crimson Stem")
        {
            AddVersion("stripped_crimson_stem")
                .WithDefaultModel<Java.Models.Block.StrippedCrimsonStem>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.HugeFungus.StrippedCrimsonStemSide>();
        }
    }
}
