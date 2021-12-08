using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DetectorRailOn : JavaBlockTexture
    {
        public DetectorRailOn() : base("Detector Rail, On")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("detector_rail_on")
                .WithDefaultModel<Java.Models.Block.DetectorRailOn>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RailDetectorPowered>();
        }
    }
}
