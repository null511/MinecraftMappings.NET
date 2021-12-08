using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LimeShulkerBox : JavaBlockTexture
    {
        public LimeShulkerBox() : base("Lime Shulker Box")
        {
            AddVersion("lime_shulker_box");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ShulkerTopLime>();
        }
    }
}
