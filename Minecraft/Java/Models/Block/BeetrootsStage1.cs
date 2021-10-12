﻿using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BeetrootsStage1 : JavaModelData
    {
        public BeetrootsStage1() : base("Beetroots, Stage 1")
        {
            AddVersion("beetroots_stage1", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/crop")
                .AddTexture("crop", "block/beetroots_stage1");
        }
    }
}
