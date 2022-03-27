using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlackShulkerBox : JavaBlockTexture
    {
        public BlackShulkerBox() : base("Black Shulker Box")
        {
            AddVersion("black_shulker_box")
                //.WithDefaultModel<Java.Models.Block.BlackShulkerBox>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ShulkerTopBlack>();
        }
    }
}
