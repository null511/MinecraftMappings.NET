using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DirtPathSide : JavaBlockTexture
    {
        public DirtPathSide() : base("Dirt Path Side")
        {
            AddVersion("dirt_path_side")
                .WithMinVersion("1.17")
                .WithDefaultModel<Java.Models.Block.DirtPath>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GrassPathSide>();
        }
    }
}
