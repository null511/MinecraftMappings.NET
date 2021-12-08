﻿using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DaylightDetectorSide : JavaBlockTexture
    {
        public DaylightDetectorSide() : base("Daylight Detector Side")
        {
            AddVersion("daylight_detector_side");
                //.WithDefaultModel<Java.Models.Block.DaylightDetector>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DaylightDetectorSide>();
        }
    }
}
