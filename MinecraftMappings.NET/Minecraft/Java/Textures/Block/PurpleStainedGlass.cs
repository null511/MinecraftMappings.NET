using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PurpleStainedGlass : JavaBlockTexture
    {
        public PurpleStainedGlass() : base("Purple Stained Glass")
        {
            BlendMode = BlendModes.Transparent;

            AddVersion("purple_stained_glass");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlassPurple>();
        }
    }
}
