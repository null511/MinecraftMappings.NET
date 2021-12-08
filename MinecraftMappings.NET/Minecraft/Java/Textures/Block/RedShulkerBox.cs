using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedShulkerBox : JavaBlockTexture
    {
        public RedShulkerBox() : base("Red Shulker Box")
        {
            AddVersion("red_shulker_box");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ShulkerTopRed>();
        }
    }
}
