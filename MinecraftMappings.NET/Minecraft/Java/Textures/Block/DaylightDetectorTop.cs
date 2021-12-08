using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DaylightDetectorTop : JavaBlockTexture
    {
        public DaylightDetectorTop() : base("Daylight Detector Top")
        {
            AddVersion("daylight_detector_top");
                //.WithDefaultModel<Java.Models.Block.DaylightDetector>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DaylightDetectorTop>();
        }
    }
}
