using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class HayBlockSide : JavaBlockTexture
    {
        public HayBlockSide() : base("Hay Block, Side")
        {
            AddVersion("hay_block_side")
                .WithMinVersion("1.6.1")
                .WithDefaultModel<Java.Models.Block.HayBlock>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.HayBlockSide>();
        }
    }
}
