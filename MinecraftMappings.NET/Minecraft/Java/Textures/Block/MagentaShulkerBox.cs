using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class MagentaShulkerBox : JavaBlockTexture
    {
        public MagentaShulkerBox() : base("Magenta Shulker Box")
        {
            AddVersion("magenta_shulker_box");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ShulkerTopMagenta>();
        }
    }
}
