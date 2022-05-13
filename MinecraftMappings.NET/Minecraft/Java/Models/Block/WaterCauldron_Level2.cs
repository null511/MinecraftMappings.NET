﻿using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WaterCauldron_Level2 : JavaBlockModel
    {
        public WaterCauldron_Level2() : base("Water Cauldron, Level 2")
        {
            AddVersion("water_cauldron_level2", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_cauldron_level2")
                .AddTexture("content", "block/water_still")
                .AddTexture("inside", "block/cauldron_inner")
                .AddTexture("top", "block/cauldron_top")
                .AddTexture("bottom", "block/cauldron_bottom")
                .AddTexture("side", "block/cauldron_side");
        }
    }
}
