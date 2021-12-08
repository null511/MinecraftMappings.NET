using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class TintedGlass : JavaBlockTexture
    {
        public TintedGlass() : base("Tinted Glass")
        {
            BlendMode = BlendModes.Transparent;

            AddVersion("tinted_glass");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.TintedGlass>();
        }
    }
}
