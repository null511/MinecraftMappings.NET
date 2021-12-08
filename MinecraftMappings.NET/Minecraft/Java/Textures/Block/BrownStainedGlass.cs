using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrownStainedGlass : JavaBlockTexture
    {
        public BrownStainedGlass() : base("Brown Stained Glass")
        {
            BlendMode = BlendModes.Transparent;

            AddVersion("brown_stained_glass");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlassBrown>();
        }
    }
}
