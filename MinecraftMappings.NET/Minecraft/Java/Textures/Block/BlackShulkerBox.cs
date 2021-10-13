using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlackShulkerBox : JavaBlockTexture
    {
        public BlackShulkerBox() : base("Black Shulker Box")
        {
            AddVersion("black_shulker_box")
                .MapsToBedrockBlock<BedrockBlocks.ShulkerTopBlack>();
        }
    }
}
