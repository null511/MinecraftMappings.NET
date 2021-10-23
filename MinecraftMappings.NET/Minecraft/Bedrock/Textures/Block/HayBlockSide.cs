using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class HayBlockSide : BedrockBlockTexture
    {
        public HayBlockSide() : base("Hay Block Side")
        {
            AddVersion("hay_block_side")
                .MapsToJavaBlock<Java.Textures.Block.HayBlockSide>();
        }
    }
}
