using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class NetherBricks : JavaBlockTexture
    {
        public NetherBricks() : base("Nether Bricks")
        {
            AddVersion("nether_bricks");
                //.WithDefaultModel<Java.Models.Block.NetherBricks>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.NetherBricks>();
        }
    }
}
