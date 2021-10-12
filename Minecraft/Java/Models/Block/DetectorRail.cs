using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DetectorRail : JavaModelData
    {
        public DetectorRail() : base("Detector Rail")
        {
            AddVersion("detector_rail", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/rail_flat")
                .AddTexture("rail", "block/detector_rail");
        }
    }
}
