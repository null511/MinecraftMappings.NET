using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GreenStainedGlass : JavaBlockTexture
    {
        public GreenStainedGlass() : base("Green Stained Glass")
        {
            BlendMode = BlendModes.Transparent;

            AddVersion("green_stained_glass");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlassGreen>();
        }
    }
}
