using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LightGrayShulkerBox : JavaBlockTexture
    {
        public LightGrayShulkerBox() : base("Light Gray Shulker Box")
        {
            AddVersion("light_gray_shulker_box");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ShulkerTopLightGray>();
        }
    }
}
