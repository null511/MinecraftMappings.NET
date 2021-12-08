using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GlowItemFrame : JavaBlockTexture
    {
        public GlowItemFrame() : base("Glow Item Frame")
        {
            AddVersion("glow_item_frame");
                //.WithDefaultModel<Java.Models.Block.GlowItemFrame>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlowItemFrame>();
        }
    }
}
