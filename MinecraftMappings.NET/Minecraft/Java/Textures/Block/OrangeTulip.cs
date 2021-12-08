using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OrangeTulip : JavaBlockTexture
    {
        public OrangeTulip() : base("Orange Tulip")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(1, "orange_tulip")
                .WithMinVersion("1.7.2")
                .WithDefaultModel<Java.Models.Block.OrangeTulip>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FlowerOrangeTulip>();
        }
    }
}
