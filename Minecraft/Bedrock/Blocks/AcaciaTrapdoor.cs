using MinecraftMappings.Internal.Blocks;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class AcaciaTrapdoor : BedrockBlockData
    {
        public AcaciaTrapdoor() : base("Acacia Trapdoor")
        {
            AddVersion("acacia_trapdoor")
                .MapsToJavaBlock<Java.Textures.Block.AcaciaTrapdoor>();
        }
    }
}
