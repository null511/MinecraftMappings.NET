using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlueShulkerBox : JavaBlockTexture
    {
        public BlueShulkerBox() : base("Blue Shulker Box")
        {
            AddVersion("blue_shulker_box")
                .MapsToBedrockBlock<BedrockBlocks.ShulkerTopBlue>();
        }
    }
}
