using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlueStainedGlass : JavaBlockTexture
    {
        public BlueStainedGlass() : base("Blue Stained Glass")
        {
            BlendMode = BlendModes.Transparent;

            AddVersion("blue_stained_glass")
                .WithDefaultModel<Java.Models.Block.BlueStainedGlass>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlassBlue>();
        }
    }
}
