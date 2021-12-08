using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GlowLichen : JavaBlockTexture
    {
        public GlowLichen() : base("Glow Lichen")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("glow_lichen");
                //.WithDefaultModel<Java.Models.Block.GlowLichen>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlowLichen>();
        }
    }
}
