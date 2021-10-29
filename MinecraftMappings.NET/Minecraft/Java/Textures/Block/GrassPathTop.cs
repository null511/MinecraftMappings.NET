using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GrassPathTop : JavaBlockTexture
    {
        public GrassPathTop() : base("Grass Path, Top")
        {
            AddVersion("grass_path_top")
                .WithMinVersion("1.0.0")
                .WithMaxVersion("1.17")
                .WithDefaultModel<Java.Models.Block.GrassPath>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GrassPathTop>();
        }
    }
}
