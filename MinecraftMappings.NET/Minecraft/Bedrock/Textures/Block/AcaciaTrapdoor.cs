using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class AcaciaTrapdoor : BedrockBlockTexture
    {
        public AcaciaTrapdoor() : base("Acacia Trapdoor")
        {
            AddVersion("acacia_trapdoor")
                .MapsToJavaBlock<Java.Textures.Block.AcaciaTrapdoor>();
        }
    }
}
