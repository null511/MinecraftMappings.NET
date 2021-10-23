using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class Ice : BedrockBlockTexture
    {
        public Ice() : base("Ice")
        {
            AddVersion("ice")
                .MapsToJavaBlock<Java.Textures.Block.Ice>();
        }
    }
}
