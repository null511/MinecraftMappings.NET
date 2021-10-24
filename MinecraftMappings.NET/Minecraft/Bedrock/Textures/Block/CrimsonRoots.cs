using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class CrimsonRoots : BedrockBlockTexture
    {
        public CrimsonRoots() : base("Crimson Roots")
        {
            AddVersion("crimson_roots")
                .MapsToJavaBlock<Java.Textures.Block.CrimsonRoots>();
        }
    }
}
