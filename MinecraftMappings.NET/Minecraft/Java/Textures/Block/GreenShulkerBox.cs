using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GreenShulkerBox : JavaBlockTexture
    {
        public GreenShulkerBox() : base("Green Shulker Box")
        {
            AddVersion("green_shulker_box");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ShulkerTopGreen>();
        }
    }
}
