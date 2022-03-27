using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DaylightDetector : JavaBlockModel
    {
        public DaylightDetector() : base("Daylight Detector")
        {
            AddVersion("daylight_detector", "1.5")
                .WithPath("models/block")
                .WithParent("block/template_daylight_detector")
                .AddTexture("top", "block/daylight_detector_top")
                .AddTexture("side", "block/daylight_detector_side");
        }
    }
}
