﻿using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Wheat_Stage6 : JavaBlockModel
    {
        public Wheat_Stage6() : base("Wheat, Stage 6")
        {
            AddVersion("wheat_stage6", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/crop")
                .AddTexture("crop", "block/wheat_stage6");
        }
    }
}
