using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OrangeShulkerBox : JavaBlockTexture
    {
        public OrangeShulkerBox() : base("Orange Shulker Box")
        {
            AddVersion("orange_shulker_box");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ShulkerTopOrange>();
        }
    }
}
