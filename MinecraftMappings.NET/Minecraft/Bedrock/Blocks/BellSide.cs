using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BellSide : BedrockBlockTexture
    {
        public BellSide() : base("Bell Side")
        {
            AddVersion("bell_side")
                .MapsToJavaBlock<Java.Textures.Block.BellSide>();
        }
    }
}
