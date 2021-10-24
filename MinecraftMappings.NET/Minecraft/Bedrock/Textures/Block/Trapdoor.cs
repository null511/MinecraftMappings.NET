using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class Trapdoor : BedrockBlockTexture
    {
        public Trapdoor() : base("Trapdoor")
        {
            AddVersion("trapdoor")
                .MapsToJavaBlock<Java.Textures.Block.OakTrapdoor>();
        }
    }
}
