using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GrassBlockTop : JavaBlockTexture
    {
        public GrassBlockTop() : base("Grass Block, Top")
        {
            AddVersion("grass_block_top")
                .WithDefaultModel<Java.Models.Block.GrassBlock>();
                //.MapsToBedrockBlock<BedrockBlocks.Grass>();
        }
    }
}
