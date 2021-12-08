using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PinkStainedGlass : JavaBlockTexture
    {
        public PinkStainedGlass() : base("Pink Stained Glass")
        {
            BlendMode = BlendModes.Transparent;

            AddVersion("pink_stained_glass");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlassPink>();
        }
    }
}
