using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WarpedStem : JavaBlockTexture
    {
        public WarpedStem() : base("Warped Stem")
        {
            AddVersion("warped_stem")
                .WithMinVersion("1.16")
                .WithDefaultModel<Java.Models.Block.WarpedStem>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WarpedStem>();
        }
    }
}
