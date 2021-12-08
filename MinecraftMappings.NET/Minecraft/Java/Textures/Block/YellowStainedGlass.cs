using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class YellowStainedGlass : JavaBlockTexture
    {
        public YellowStainedGlass() : base("Yellow Stained Glass")
        {
            BlendMode = BlendModes.Transparent;

            AddVersion("yellow_stained_glass");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlassYellow>();
        }
    }
}
