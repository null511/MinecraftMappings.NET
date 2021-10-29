using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DirtPathSideOverlay : JavaBlockTexture
    {
        public DirtPathSideOverlay() : base("Dirt Path Side Overlay")
        {
            AddVersion("dirt_path_side_overlay")
                .WithMinVersion("1.17")
                .WithDefaultModel<Java.Models.Block.DirtPathOverlay>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GrassPathSideOverlay>();
        }
    }
}
