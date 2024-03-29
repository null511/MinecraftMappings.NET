﻿using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DetectorRailOn : JavaBlockModel
    {
        public DetectorRailOn() : base("Detector Rail On")
        {
            AddVersion("detector_rail_on", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/rail_flat")
                .AddTexture("rail", "block/detector_rail_on");
        }
    }
}
