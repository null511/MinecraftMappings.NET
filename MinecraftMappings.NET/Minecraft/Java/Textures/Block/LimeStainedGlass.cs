using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LimeStainedGlass : JavaBlockTexture
    {
        public LimeStainedGlass() : base("Lime Stained Glass")
        {
            BlendMode = BlendModes.Transparent;

            AddVersion("lime_stained_glass");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlassLime>();
        }
    }
}
