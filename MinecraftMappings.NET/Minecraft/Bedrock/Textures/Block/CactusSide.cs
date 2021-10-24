using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class CactusSide : BedrockBlockTexture
    {
        public CactusSide() : base("Cactus Side")
        {
            AddVersion("cactus_side")
                .MapsToJavaBlock<Java.Textures.Block.CactusSide>();
        }
    }
}
