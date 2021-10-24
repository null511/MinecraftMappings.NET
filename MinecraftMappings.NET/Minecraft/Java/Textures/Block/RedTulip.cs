using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedTulip : JavaBlockTexture
    {
        public RedTulip() : base("Red Tulip")
        {
            AddVersion("red_tulip")
                .WithMinVersion("1.0.0")
                .WithDefaultModel<Java.Models.Block.RedTulip>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FlowerRedTulip>();
        }
    }
}
