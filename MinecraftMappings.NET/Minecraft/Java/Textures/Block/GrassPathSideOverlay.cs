using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GrassPathSideOverlay : JavaBlockTexture
    {
        public GrassPathSideOverlay() : base("Grass Path Side Overlay")
        {
            AddVersion("grass_path_side_overlay")
                .WithMinVersion("1.0.0")
                .WithMaxVersion("1.17")
                .WithDefaultModel<Java.Models.Block.GrassPathOverlay>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GrassPathSideOverlay>();
        }
    }
}
