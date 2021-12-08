using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DaylightDetectorInvertedTop : JavaBlockTexture
    {
        public DaylightDetectorInvertedTop() : base("Daylight Detector, Inverted Top")
        {
            AddVersion("daylight_detector_inverted_top");
                //.WithDefaultModel<Java.Models.Block.DaylightDetector>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DaylightDetectorInvertedTop>();
        }
    }
}
