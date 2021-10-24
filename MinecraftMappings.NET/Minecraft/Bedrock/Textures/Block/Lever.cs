using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class Lever : BedrockBlockTexture
    {
        public Lever() : base("Lever")
        {
            AddVersion("lever")
                .MapsToJavaBlock<Java.Textures.Block.Lever>();
        }
    }
}
