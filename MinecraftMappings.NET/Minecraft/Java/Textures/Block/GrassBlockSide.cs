using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GrassBlockSide : JavaBlockTexture
    {
        public GrassBlockSide() : base("Grass Block, Side")
        {
            AddVersion("grass_block_side")
                .WithDefaultModel<Java.Models.Block.GrassBlock>();
                //.MapsToBedrockBlock<BedrockBlocks.Grass>();
        }
    }
}
