using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class QuartzBricks : JavaBlockTexture
    {
        public QuartzBricks() : base("Quartz Bricks")
        {
            AddVersion("quartz_bricks");
                //.WithDefaultModel<Java.Models.Block.QuartzBricks>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.QuartzBricks>();
        }
    }
}
