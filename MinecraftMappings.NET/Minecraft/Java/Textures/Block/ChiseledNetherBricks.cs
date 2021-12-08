using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ChiseledNetherBricks : JavaBlockTexture
    {
        public ChiseledNetherBricks() : base("Chiseled Nether Bricks")
        {
            AddVersion("chiseled_nether_bricks");
                //.WithDefaultModel<Java.Models.Block.ChiseledNetherBricks>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ChiseledNetherBricks>();
        }
    }
}
