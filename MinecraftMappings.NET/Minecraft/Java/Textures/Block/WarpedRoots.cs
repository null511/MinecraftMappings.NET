using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WarpedRoots : JavaBlockTexture
    {
        public WarpedRoots() : base("Warped Roots")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("warped_roots");
                //.WithDefaultModel<Java.Models.Block.WarpedRoots>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WarpedRoots>();
        }
    }
}
