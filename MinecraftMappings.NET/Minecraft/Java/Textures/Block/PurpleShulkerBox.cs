using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PurpleShulkerBox : JavaBlockTexture
    {
        public PurpleShulkerBox() : base("Purple Shulker Box")
        {
            AddVersion("purple_shulker_box");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ShulkerTopPurple>();
        }
    }
}
