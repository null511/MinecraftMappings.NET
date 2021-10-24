using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class Cobblestone : BedrockBlockTexture
    {
        public Cobblestone() : base("Cobblestone")
        {
            AddVersion("cobblestone")
                .MapsToJavaBlock<Java.Textures.Block.Cobblestone>();
        }
    }
}
