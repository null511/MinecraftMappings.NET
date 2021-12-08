using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GrayShulkerBox : JavaBlockTexture
    {
        public GrayShulkerBox() : base("Gray Shulker Box")
        {
            AddVersion("gray_shulker_box");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ShulkerTopGray>();
        }
    }
}
