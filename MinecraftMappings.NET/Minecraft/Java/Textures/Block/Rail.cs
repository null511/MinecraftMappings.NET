using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Rail : JavaBlockTexture
    {
        public Rail() : base("Rail")
        {
            AddVersion("rail")
                .WithDefaultModel<Java.Models.Block.Rail>();
                //.MapsToBedrockBlock<BedrockBlocks.Rail>();
        }
    }
}
