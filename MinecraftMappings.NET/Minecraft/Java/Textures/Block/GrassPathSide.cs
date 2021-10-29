using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GrassPathSide : JavaBlockTexture
    {
        public GrassPathSide() : base("Grass Path, Side")
        {
            AddVersion("grass_path_side")
                .WithMinVersion("1.0.0")
                .WithMaxVersion("1.17")
                .WithDefaultModel<Java.Models.Block.GrassPath>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GrassPathSide>();
        }
    }
}
