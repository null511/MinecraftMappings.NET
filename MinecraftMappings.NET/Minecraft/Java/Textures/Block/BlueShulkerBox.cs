using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlueShulkerBox : JavaBlockTexture
    {
        public BlueShulkerBox() : base("Blue Shulker Box")
        {
            AddVersion("blue_shulker_box")
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ShulkerTopBlue>();
        }
    }
}
