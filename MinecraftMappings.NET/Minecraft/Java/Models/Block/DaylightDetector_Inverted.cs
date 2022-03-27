using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DaylightDetector_Inverted : JavaBlockModel
    {
        public DaylightDetector_Inverted() : base("Daylight Detector, Inverted")
        {
            AddVersion("daylight_detector", "1.5")
                .WithPath("models/block")
                .WithParent("block/template_daylight_detector")
                .AddTexture("top", "block/daylight_detector_inverted_top")
                .AddTexture("side", "block/daylight_detector_side");
        }
    }
}
