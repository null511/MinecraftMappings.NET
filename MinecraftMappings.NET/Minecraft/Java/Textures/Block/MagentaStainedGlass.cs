using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class MagentaStainedGlass : JavaBlockTexture
    {
        public MagentaStainedGlass() : base("Magenta Stained Glass")
        {
            BlendMode = BlendModes.Transparent;

            AddVersion("magenta_stained_glass");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlassMagenta>();
        }
    }
}
