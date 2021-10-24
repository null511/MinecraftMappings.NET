using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class Tallgrass : BedrockBlockTexture
    {
        public Tallgrass() : base("Tallgrass")
        {
            AddVersion("tallgrass")
                .MapsToJavaBlock<Java.Textures.Block.Grass>();
        }
    }
}
