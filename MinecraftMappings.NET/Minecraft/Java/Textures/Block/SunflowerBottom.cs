using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SunflowerBottom : JavaBlockTexture
    {
        public SunflowerBottom() : base("Sunflower Bottom")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("sunflower_bottom")
                .WithMinVersion("1.7.2")
                .WithDefaultModel<Java.Models.Block.SunflowerBottom>();
                //.MapsToBedrockBlock<BedrockBlocks.SunflowerBottom>();
        }
    }
}
