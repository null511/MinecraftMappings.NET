using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OrangeTulip : JavaBlockTexture
    {
        public OrangeTulip() : base("Orange Tulip")
        {
            AddVersion("orange_tulip")
                .WithMinVersion("1.0.0")
                .WithDefaultModel<Java.Models.Block.OrangeTulip>();
                //.MapsToBedrockBlock<BedrockBlocks.OrangeTulip>();
        }
    }
}
