using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class Blackstone : BedrockBlockTexture
    {
        public Blackstone() : base("Blackstone")
        {
            AddVersion("blackstone")
                .MapsToJavaBlock<Java.Textures.Block.Blackstone>();
        }
    }
}
