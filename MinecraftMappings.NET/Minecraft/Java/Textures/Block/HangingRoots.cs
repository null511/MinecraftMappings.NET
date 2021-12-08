using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class HangingRoots : JavaBlockTexture
    {
        public HangingRoots() : base("Hanging Roots")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("hanging_roots");
                //.WithDefaultModel<Java.Models.Block.HangingRoots>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.HangingRoots>();
        }
    }
}
