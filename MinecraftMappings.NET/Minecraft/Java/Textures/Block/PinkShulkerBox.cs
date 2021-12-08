using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PinkShulkerBox : JavaBlockTexture
    {
        public PinkShulkerBox() : base("Pink Shulker Box")
        {
            AddVersion("pink_shulker_box");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ShulkerTopPink>();
        }
    }
}
