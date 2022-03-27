using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DaylightDetectorInvertedTop : JavaBlockTexture
    {
        public DaylightDetectorInvertedTop() : base("Daylight Detector, Inverted Top")
        {
            AddVersion("daylight_detector_inverted_top")
                .WithMinVersion("1.5")
                .WithDefaultModel<Java.Models.Block.DaylightDetector_Inverted>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DaylightDetectorInvertedTop>();
        }
    }
}
