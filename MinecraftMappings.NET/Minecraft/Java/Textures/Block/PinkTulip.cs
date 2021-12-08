using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PinkTulip : JavaBlockTexture
    {
        public PinkTulip() : base("Pink Tulip")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(1, "pink_tulip")
                .WithMinVersion("1.7.2")
                .WithDefaultModel<Java.Models.Block.PinkTulip>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FlowerPinkTulip>();
        }
    }
}
