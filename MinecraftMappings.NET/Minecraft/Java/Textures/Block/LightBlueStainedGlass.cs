using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LightBlueStainedGlass : JavaBlockTexture
    {
        public LightBlueStainedGlass() : base("Light Blue Stained Glass")
        {
            BlendMode = BlendModes.Transparent;

            AddVersion("light_blue_stained_glass");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlassLightBlue>();
        }
    }
}
