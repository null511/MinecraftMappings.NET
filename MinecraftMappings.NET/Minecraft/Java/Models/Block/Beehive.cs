﻿using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Beehive : JavaBlockModel
    {
        public Beehive() : base("Beehive")
        {
            AddVersion("beehive", "1.15")
                .WithPath("models/block")
                .WithParent("block/orientable_with_bottom")
                .AddTexture("top", "block/beehive_end")
                .AddTexture("bottom", "block/beehive_end")
                .AddTexture("side", "block/beehive_side")
                .AddTexture("front", "block/beehive_front");
        }
    }
}
