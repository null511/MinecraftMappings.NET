using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SunflowerTop : JavaBlockTexture
    {
        public SunflowerTop() : base("Sunflower Top")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("sunflower_top")
                .WithMinVersion("1.7.2")
                .WithDefaultModel<Java.Models.Block.SunflowerTop>();
                //.MapsToBedrockBlock<BedrockBlocks.SunflowerTop>();
        }
    }
}
