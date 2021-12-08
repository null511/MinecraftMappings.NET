using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DetectorRail : JavaBlockTexture
    {
        public DetectorRail() : base("Detector Rail")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("detector_rail")
                .WithDefaultModel<Java.Models.Block.DetectorRail>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RailDetector>();
        }
    }
}
