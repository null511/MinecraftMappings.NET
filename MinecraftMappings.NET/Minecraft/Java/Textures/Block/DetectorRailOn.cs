using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DetectorRailOn : JavaBlockTexture
    {
        public DetectorRailOn() : base("Detector Rail, On")
        {
            AddVersion("detector_rail_on")
                .WithDefaultModel<Java.Models.Block.DetectorRailOn>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RailDetectorPowered>();
        }
    }
}
