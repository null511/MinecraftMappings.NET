using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GrayStainedGlass : JavaBlockTexture
    {
        public GrayStainedGlass() : base("Gray Stained Glass")
        {
            BlendMode = BlendModes.Transparent;

            AddVersion("gray_stained_glass");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlassGray>();
        }
    }
}
