using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SunflowerFront : JavaBlockTexture
    {
        public SunflowerFront() : base("Sunflower Front")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("sunflower_front")
                .WithMinVersion("1.7.2")
                .WithDefaultModel<Java.Models.Block.SunflowerTop>();
                //.MapsToBedrockBlock<BedrockBlocks.SunflowerFront>();
        }
    }
}
