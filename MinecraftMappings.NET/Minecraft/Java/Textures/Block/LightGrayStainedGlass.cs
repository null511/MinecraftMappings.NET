using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LightGrayStainedGlass : JavaBlockTexture
    {
        public LightGrayStainedGlass() : base("Light Gray Stained Glass")
        {
            BlendMode = BlendModes.Transparent;

            AddVersion("light_gray_stained_glass");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlassLightGray>();
        }
    }
}
