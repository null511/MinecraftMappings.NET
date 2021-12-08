using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrownShulkerBox : JavaBlockTexture
    {
        public BrownShulkerBox() : base("Brown Shulker Box")
        {
            AddVersion("brown_shulker_box");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ShulkerTopBrown>();
        }
    }
}
