using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WarpedRootsPot : JavaBlockTexture
    {
        public WarpedRootsPot() : base("Warped Roots Pot")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("warped_roots_pot");
                //.WithDefaultModel<Java.Models.Block.WarpedRootsPot>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WarpedRootsPot>();
        }
    }
}
