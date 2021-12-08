using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CyanShulkerBox : JavaBlockTexture
    {
        public CyanShulkerBox() : base("Cyan Shulker Box")
        {
            AddVersion("cyan_shulker_box");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ShulkerTopCyan>();
        }
    }
}
