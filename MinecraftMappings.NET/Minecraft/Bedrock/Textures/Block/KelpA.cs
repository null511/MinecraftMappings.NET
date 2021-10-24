using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class KelpA : BedrockBlockTexture
    {
        public KelpA() : base("Kelp, A")
        {
            AddVersion("kelp_a")
                .MapsToJavaBlock<Java.Textures.Block.KelpPlant>();
        }
    }
}
