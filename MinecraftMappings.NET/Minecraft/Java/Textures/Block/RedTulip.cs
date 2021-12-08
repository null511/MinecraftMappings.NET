using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedTulip : JavaBlockTexture
    {
        public RedTulip() : base("Red Tulip")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(1, "red_tulip")
                .WithMinVersion("1.7.2")
                .WithDefaultModel<Java.Models.Block.RedTulip>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FlowerRedTulip>();
        }
    }
}
