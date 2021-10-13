using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class Brick : BedrockBlockTexture
    {
        public Brick() : base("Brick")
        {
            AddVersion("brick")
                .MapsToJavaBlock<Java.Textures.Block.Bricks>();
        }
    }
}
