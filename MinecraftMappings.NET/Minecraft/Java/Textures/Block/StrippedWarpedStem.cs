using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class StrippedWarpedStem : JavaBlockTexture
    {
        public StrippedWarpedStem() : base("Stripped Warped Stem")
        {
            AddVersion("stripped_warped_stem")
                .WithDefaultModel<Java.Models.Block.StrippedWarpedStem>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.StrippedWarpedStem>();
        }
    }
}
