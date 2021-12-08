using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WhiteTulip : JavaBlockTexture
    {
        public WhiteTulip() : base("White Tulip")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(1, "white_tulip")
                .WithMinVersion("1.7.2")
                .WithDefaultModel<Java.Models.Block.WhiteTulip>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FlowerWhiteTulip>();
        }
    }
}
