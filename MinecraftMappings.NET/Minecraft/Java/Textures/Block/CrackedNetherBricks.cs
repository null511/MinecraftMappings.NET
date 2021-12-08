using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CrackedNetherBricks : JavaBlockTexture
    {
        public CrackedNetherBricks() : base("Cracked Nether Bricks")
        {
            AddVersion("cracked_nether_bricks");
                //.WithDefaultModel<Java.Models.Block.CrackedNetherBricks>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CrackedNetherBricks>();
        }
    }
}
