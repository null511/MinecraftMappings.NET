using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class RailDetector : BedrockBlockTexture
    {
        public RailDetector() : base("Rail Detector")
        {
            AddVersion("rail_detector")
                .MapsToJavaBlock<Java.Textures.Block.DetectorRail>();
        }
    }
}
