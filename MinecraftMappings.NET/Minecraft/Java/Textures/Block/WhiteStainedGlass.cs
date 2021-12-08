using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WhiteStainedGlass : JavaBlockTexture
    {
        public WhiteStainedGlass() : base("White Stained Glass")
        {
            BlendMode = BlendModes.Transparent;

            AddVersion("white_stained_glass");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlassWhite>();
        }
    }
}
