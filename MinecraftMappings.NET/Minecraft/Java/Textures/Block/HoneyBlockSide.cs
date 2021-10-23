using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class HoneyBlockSide : JavaBlockTexture
    {
        public HoneyBlockSide() : base("Honey Block Side")
        {
            AddVersion("honey_block_side")
                .WithMinVersion("1.15")
                .WithDefaultModel<Java.Models.Block.HoneyBlock>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.HoneySide>();
        }
    }
}
