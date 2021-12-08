using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CyanStainedGlass : JavaBlockTexture
    {
        public CyanStainedGlass() : base("Cyan Stained Glass")
        {
            BlendMode = BlendModes.Transparent;

            AddVersion("cyan_stained_glass");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlassCyan>();
        }
    }
}
