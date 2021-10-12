using MinecraftMappings.Internal.Blocks;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class Brick : BedrockBlockData
    {
        public Brick() : base("Brick")
        {
            AddVersion("brick")
                .MapsToJavaBlock<Java.Textures.Block.Bricks>();
        }
    }
}
