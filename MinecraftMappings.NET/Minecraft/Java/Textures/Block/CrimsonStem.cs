using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CrimsonStem : JavaBlockTexture
    {
        public CrimsonStem() : base("Crimson Stem")
        {
            AddVersion("crimson_stem")
                .WithMinVersion("1.16")
                .WithDefaultModel<Java.Models.Block.CrimsonStem>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CrimsonStem>();
        }
    }
}
