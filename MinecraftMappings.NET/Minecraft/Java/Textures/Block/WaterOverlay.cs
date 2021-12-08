using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WaterOverlay : JavaBlockTexture
    {
        public WaterOverlay() : base("Water Overlay")
        {
            BlendMode = BlendModes.Transparent;

            AddVersion("water_overlay");
                //.WithDefaultModel<Java.Models.Block.WaterOverlay>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WaterOverlay>();
        }
    }
}
