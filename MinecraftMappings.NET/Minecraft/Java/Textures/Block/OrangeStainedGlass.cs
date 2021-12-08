using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OrangeStainedGlass : JavaBlockTexture
    {
        public OrangeStainedGlass() : base("Orange Stained Glass")
        {
            BlendMode = BlendModes.Transparent;

            AddVersion("orange_stained_glass");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlassOrange>();
        }
    }
}
