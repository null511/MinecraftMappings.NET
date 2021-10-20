using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GrassPathSide : JavaBlockTexture
    {
        public GrassPathSide() : base("Grass Path, Side")
        {
            AddVersion("grass_path_side")
                .WithDefaultModel<Java.Models.Block.GrassPath>();
                //.MapsToBedrockBlock<BedrockBlocks.Grass>();
        }
    }
}
