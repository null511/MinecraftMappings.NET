using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WhiteTulip : JavaBlockTexture
    {
        public WhiteTulip() : base("White Tulip")
        {
            AddVersion("white_tulip")
                .WithMinVersion("1.0.0")
                .WithDefaultModel<Java.Models.Block.WhiteTulip>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FlowerWhiteTulip>();
        }
    }
}
