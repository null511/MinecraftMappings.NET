using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class StoneBricks : JavaBlockTexture
    {
        public StoneBricks() : base("Stone Bricks")
        {
            AddVersion("stone_bricks");
                //.WithDefaultModel<Java.Models.Block.StoneBricks>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.StoneBricks>();
        }
    }
}
