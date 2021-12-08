using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedNetherBricks : JavaBlockTexture
    {
        public RedNetherBricks() : base("Red Nether Bricks")
        {
            AddVersion("red_nether_bricks");
                //.WithDefaultModel<Java.Models.Block.RedNetherBricks>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RedNetherBricks>();
        }
    }
}
