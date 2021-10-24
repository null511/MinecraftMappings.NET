using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class Ladder : BedrockBlockTexture
    {
        public Ladder() : base("Ladder")
        {
            AddVersion("ladder")
                .MapsToJavaBlock<Java.Textures.Block.Ladder>();
        }
    }
}
