using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ShulkerBox : JavaBlockTexture
    {
        public ShulkerBox() : base("Shulker Box")
        {
            AddVersion("shulker_box");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ShulkerTop>();
        }
    }
}
