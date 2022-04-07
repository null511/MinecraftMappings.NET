using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.HugeFungus
{
    public class CrimsonTrapdoor : BedrockBlockTexture
    {
        public CrimsonTrapdoor() : base("Crimson Trapdoor")
        {
            AddVersion("crimson_trapdoor")
                .MapsToJavaBlock<Java.Textures.Block.CrimsonTrapdoor>();
        }
    }
}
