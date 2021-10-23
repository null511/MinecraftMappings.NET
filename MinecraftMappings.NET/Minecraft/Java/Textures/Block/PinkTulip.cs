using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PinkTulip : JavaBlockTexture
    {
        public PinkTulip() : base("Pink Tulip")
        {
            AddVersion("pink_tulip")
                .WithMinVersion("1.0.0")
                .WithDefaultModel<Java.Models.Block.PinkTulip>();
                //.MapsToBedrockBlock<BedrockBlocks.PinkTulip>();
        }
    }
}
