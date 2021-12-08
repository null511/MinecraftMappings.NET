using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedStainedGlass : JavaBlockTexture
    {
        public RedStainedGlass() : base("Red Stained Glass")
        {
            BlendMode = BlendModes.Transparent;

            AddVersion("red_stained_glass");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlassRed>();
        }
    }
}
