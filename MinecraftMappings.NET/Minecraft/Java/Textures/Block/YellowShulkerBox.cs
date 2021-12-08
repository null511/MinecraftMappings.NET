using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class YellowShulkerBox : JavaBlockTexture
    {
        public YellowShulkerBox() : base("Yellow Shulker Box")
        {
            AddVersion("yellow_shulker_box");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ShulkerTopYellow>();
        }
    }
}
