using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlackStainedGlass : JavaBlockTexture
    {
        public BlackStainedGlass() : base("Black Stained Glass")
        {
            BlendMode = BlendModes.Transparent;

            AddVersion("black_stained_glass")
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlassBlack>();
        }
    }
}
