using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class RailDetectorPowered : BedrockBlockTexture
    {
        public RailDetectorPowered() : base("Rail Detector, Powered")
        {
            AddVersion("rail_detector_powered")
                .MapsToJavaBlock<Java.Textures.Block.DetectorRailOn>();
        }
    }
}
