using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GrassBlockSideOverlay : JavaBlockTexture
    {
        public GrassBlockSideOverlay() : base("Grass Block, Side Overlay")
        {
            AddVersion("grass_block_side_overlay")
                .WithDefaultModel<Java.Models.Block.GrassBlockOverlay>();
                //.MapsToBedrockBlock<BedrockBlocks.Grass>();
        }
    }
}
