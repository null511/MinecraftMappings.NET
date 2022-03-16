using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SunflowerBack : JavaBlockTexture
    {
        public SunflowerBack() : base("Sunflower Back")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("sunflower_back")
                .WithMinVersion("1.7.2")
                .WithDefaultModel<Java.Models.Block.SunflowerTop>();
                //.MapsToBedrockBlock<BedrockBlocks.SunflowerBack>();
        }
    }
}
