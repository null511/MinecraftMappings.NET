using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WhiteShulkerBox : JavaBlockTexture
    {
        public WhiteShulkerBox() : base("White Shulker Box")
        {
            AddVersion("white_shulker_box");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ShulkerTopWhite>();
        }
    }
}
